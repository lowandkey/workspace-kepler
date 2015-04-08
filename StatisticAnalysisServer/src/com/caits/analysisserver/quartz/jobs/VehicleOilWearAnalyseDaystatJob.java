package com.caits.analysisserver.quartz.jobs;

import java.util.Date;

import org.quartz.JobExecutionContext;
import org.quartz.JobExecutionException;

import com.caits.analysisserver.quartz.MyJob;
import com.caits.analysisserver.quartz.jobs.impl.VehicleOilWearAnalyseDaystatJobdetail;
import com.caits.analysisserver.utils.CDate;

/**
 * 管理报表--单车油耗分析日报
 * 运行频率：每日车辆日统计结果生成后执行  3点10分
 * @author yujch
 */
public class VehicleOilWearAnalyseDaystatJob extends MyJob {
	
	private String jobName = "VehicleOilWearAnalyseDaystatJob";
	
	@Override
	public String getJobName() {
		// TODO Auto-generated method stub
		return this.jobName;
	}
	
/*	@Override
	public int executePrev() {
		// TODO Auto-generated method stub
		return JobMonitor.getInstance().queryJobDependStatus("OrgAlarmDaystatJob");
	}*/

	/*
	 * 每日统计前一日数据
	 * 
	 * @see org.quartz.Job#execute(org.quartz.JobExecutionContext)
	 */
	@Override
	public int executeJob(JobExecutionContext arg0) throws JobExecutionException {
		// TODO Auto-generated method stub
		long yesterdayNoon = CDate.getYesDayYearMonthDay()+1000*60*60*12;//昨天中午日期时间
		Date dt = new Date();
		dt.setTime(yesterdayNoon);
		
		VehicleOilWearAnalyseDaystatJobdetail jobDetail = new VehicleOilWearAnalyseDaystatJobdetail(dt);
		
		return jobDetail.executeStatRecorder();
	}

	
/*
	@Override
	public int executeEnd(int execFlag) {
		// TODO Auto-generated method stub
		return JobMonitor.getInstance().updateJobRunningMonitor("OrgAlarmDaystatJob", ""+execFlag, new Date());
	}*/
}