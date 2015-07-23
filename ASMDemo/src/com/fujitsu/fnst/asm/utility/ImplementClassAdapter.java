package com.fujitsu.fnst.asm.utility;

import org.objectweb.asm.ClassAdapter;
import org.objectweb.asm.ClassVisitor;
import org.objectweb.asm.MethodVisitor;

/**
 * This class is used to filter the implement class. The implement class's
 * bytecode is used to combined to the origin class. But the <init> method must
 * be removed.
 * 
 * @author paul
 * 
 */
public class ImplementClassAdapter extends ClassAdapter {

	public ImplementClassAdapter(ClassVisitor cv) {
		super(cv);
	}

	@Override
	public void visit(int version, int access, String name, String signature,
			String superName, String[] interfaces) {
		// ��ʵ�֣����ò������ݹ��˵�
	}

	@Override
	public MethodVisitor visitMethod(int access, String name, String desc,
			String signature, String[] exceptions) {
		//�����췽�����˵�
		if (AddImplementClassAdapter.INTERNAL_INIT_METHOD_NAME.equals(name)) {
			return null;
		}
		return cv.visitMethod(access, name, desc, signature, exceptions);
	}

}
