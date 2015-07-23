package com.fujitsu.fnst.asm.utility;

import java.io.IOException;

import org.objectweb.asm.ClassAdapter;
import org.objectweb.asm.ClassReader;
import org.objectweb.asm.ClassWriter;
import org.objectweb.asm.MethodVisitor;
import org.objectweb.asm.Opcodes;

/**
 * This class is used to add implement classes' bytecode to the original class.
 * The new class is extends the original class,and name with
 * orginalClass+"$PROXY";
 * 
 * @author paul
 * 
 */
public class AddImplementClassAdapter extends ClassAdapter {
	public static final String INTERNAL_INIT_METHOD_NAME = "<init>";
	private ClassWriter classWriter;
	private Class<?>[] implementClasses;
	private String originalClassName;
	private String enhancedClassName;

	public AddImplementClassAdapter(String enhancedClassName,
			Class<?> targetClass, ClassWriter writer,
			Class<?>... implementClasses) {
		super(writer);
		this.classWriter = writer;
		this.implementClasses = implementClasses;
		this.originalClassName = targetClass.getName();
		this.enhancedClassName = enhancedClassName;
	}

	@Override
	public void visit(int version, int access, String name, String signature,
			String superName, String[] interfaces) {
		// �޸��������� Java ��������������滻Ϊ�������ʹ�õ���ʽ
		//����ǿ������Ϊ����ǿ�������
		cv.visit(version, Opcodes.ACC_PUBLIC,
				enhancedClassName.replace('.', '/'), signature, name,
				interfaces);
	}

	@Override
	public MethodVisitor visitMethod(int access, String name, String desc,
			String signature, String[] exceptions) {
		/*visitMethod ��������Ҫ�ж�����ǹ��췽����ͨ�� ModifyInitMethodAdapter �޸Ĺ��췽����
		��������ֱ�ӷ��� null ��������Ϊ��ǿ���Ѿ��Ӵ���ǿ���м̳�����Щ������
		������Щ��������Ҫ����ǿ�����ٳ���һ�飩*/
		if (INTERNAL_INIT_METHOD_NAME.equals(name)) {
			MethodVisitor mv = classWriter.visitMethod(access,
					INTERNAL_INIT_METHOD_NAME, desc, signature, exceptions);
			return new ModifyInitMethodAdapter(mv, originalClassName);
		}
		return null;
	}

	@Override
	public void visitEnd() {
		//ʹ�� ImplementClassAdapter �� ClassWriter ��ʵ�����������ӵ���ǿ����
		for (Class<?> clazz : implementClasses) {
			try {
				// �����ʵ�����������ӵ���ǿ���У�clazz.getName()��
				ClassReader reader = new ClassReader(clazz.getName());
				ClassAdapter adapter = new ImplementClassAdapter(classWriter);
				reader.accept(adapter, 0);
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
		cv.visitEnd();
	}
}
