﻿using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MyQuartz
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameValueCollection properties = new NameValueCollection();
            //properties["quartz.scheduler.instanceName"] = "XmlConfiguredInstance";

            //// set thread pool info
            //properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";
            //properties["quartz.threadPool.threadCount"] = "5";
            //properties["quartz.threadPool.threadPriority"] = "Normal";

            //// job initialization plugin handles our xml reading, without it defaults are used
            //properties["quartz.plugin.xml.type"] = "Quartz.Plugin.Xml.XMLSchedulingDataProcessorPlugin, Quartz";
            //properties["quartz.plugin.xml.fileNames"] = "~/quartz_jobs.xml";
            // ISchedulerFactory factory = new StdSchedulerFactory(properties); //新建一个调度器工厂 
            ISchedulerFactory factory = new StdSchedulerFactory();
            //Quartz.
            IScheduler scheduler = factory.GetScheduler();//工厂生成一个调度器 
          
            scheduler.Start();//启动调度器 
            //IJobDetail job = JobBuilder.Create<SimpleJob>().WithIdentity("SampleJob", "JobGroup1").Build();//新建一个任务 
            //ITrigger trigger = TriggerBuilder.Create().StartAt(DateTimeOffset.Now.AddSeconds(10)).Build();//创建触发器 

            //scheduler.ScheduleJob(job, trigger);//将任务与触发器关联起来放到调度器中 

            Console.Read();
        }
    }


    public class SimpleJob : IJob
    {
        private int _count = 0;
        public void Execute(IJobExecutionContext context)
        {
            _count++;
            Console.WriteLine(" 任务执行了 " + _count);
        }
    }
}
