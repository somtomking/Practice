using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MyQuartz
{
    class StartWithDb
    {
        static void Main(string[] args)
        {
            NameValueCollection properties = new NameValueCollection();

            properties["quartz.scheduler.instanceName"] = "TestScheduler";
            properties["quartz.scheduler.instanceId"] = "instance_one";
            properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";
            properties["quartz.threadPool.threadCount"] = "5";
            properties["quartz.threadPool.threadPriority"] = "Normal";
            properties["quartz.jobStore.misfireThreshold"] = "60000";
            properties["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX, Quartz";
            properties["quartz.jobStore.useProperties"] = "false";
            properties["quartz.jobStore.dataSource"] = "default";
            properties["quartz.jobStore.tablePrefix"] = "QRTZ_";
            properties["quartz.jobStore.clustered"] = "true";
            // if running SQLite we need this
            // properties["quartz.jobStore.lockHandler.type"] = "Quartz.Impl.AdoJobStore.UpdateLockRowSemaphore, Quartz";
            properties["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.SqlServerDelegate, Quartz";

            properties["quartz.dataSource.default.connectionString"] = @"Server=.\sql12;Database=Quartz_Task;user id=sa;password=sa123;Trusted_Connection=True;";
            properties["quartz.dataSource.default.provider"] = "SqlServer-20";

            ISchedulerFactory factory = new StdSchedulerFactory(properties);
            //Quartz.
            IScheduler scheduler = factory.GetScheduler();//工厂生成一个调度器 

            scheduler.Start();//启动调度器 
            IJobDetail job = JobBuilder.Create<SimpleJob>().WithIdentity("SampleJob1", "JobGroup1").Build();//新建一个任务 
            ITrigger trigger = TriggerBuilder.Create()
                .WithSimpleSchedule(s => s.WithIntervalInSeconds(5).WithRepeatCount(-1))
                .Build();//创建触发器 



            scheduler.ScheduleJob(job, trigger);//将任务与触发器关联起来放到调度器中 


            Console.Read();
        }
    }
}
