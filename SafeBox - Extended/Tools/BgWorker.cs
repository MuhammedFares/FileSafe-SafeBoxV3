using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SafeBox3.Tools
{
   public class BgWorker
    {
        public abstract class Job
        {
            /// <summary>
            /// Execute the Job itself, one ore repeatedly, depending on
            /// the job implementation.
            /// </summary>
            public void ExecuteJob()
            {
                if (IsRepeatable())
                {
                    // execute the job in intervals determined by the methd
                    // GetRepetionIntervalTime()
                    while (true)
                    {
                        DoJob();
                        Thread.Sleep(GetRepetitionIntervalTime());
                    }
                }
                // since there is no repetetion, simply execute the job
                else
                {
                    DoJob();
                }
            }

            public void ExecuteJobAsync()
            {
                if (IsRepeatable())
                {
                    // execute the job in intervals determined by the methd
                    // GetRepetionIntervalTime()
                    while (true)
                    {
                        Task x = Task.Run(() =>
                        {
                            DoJob();
                            Thread.Sleep(GetRepetitionIntervalTime());
                        }); x.Wait();
                    }
                }
                // since there is no repetetion, simply execute the job
                else
                {
                    Task x = Task.Run(() =>
                    {
                        DoJob();
                    }); x.Wait();

                }
            }

            /// <summary>
            /// If this method is overriden, on can get within the job
            /// parameters set just before the job is started. In this
            /// situation the application is running and the use may have
            /// access to resources which he/she has not during the thread
            /// execution. For instance, in a web application, the user has
            /// no access to the application context, when the thread is running.
            /// Note that this method must not be overriden. It is optional.
            /// </summary>
            /// <returns>Parameters to be used in the job.</returns>
            public virtual Object GetParameters()
            {
                return null;
            }

            /// <summary>
            /// Get the Job´s Name. This name uniquely identifies the Job.
            /// </summary>
            /// <returns>Job´s name.</returns>
            public abstract String GetName();

            public abstract bool isExcuteable();

            /// <summary>
            /// The job to be executed.
            /// </summary>
            public abstract void DoJob();

            /// <summary>
            /// Determines whether a Job is to be repeated after a
            /// certain amount of time.
            /// </summary>
            /// <returns>True in case the Job is to be repeated, false otherwise.</returns>
            public abstract bool IsRepeatable();

            /// <summary>
            /// The amount of time, in milliseconds, which the Job has to wait until it is started
            /// over. This method is only useful if IJob.IsRepeatable() is true, otherwise
            /// its implementation is ignored.
            /// </summary>
            /// <returns>Interval time between this job executions.</returns>
            public abstract int GetRepetitionIntervalTime();
        }
        public class JobManager
        {

            /// <summary>
            /// Execute all Jobs.
            /// </summary>
            public void ExecuteAllJobs()
            {
                Debug.WriteLine("Begin Method");

                try
                {
                    // get all job implementations of this assembly.
                    IEnumerable<Type> jobs = GetAllTypesImplementingInterface(typeof(Job));
                    // execute each job
                    if (jobs != null && jobs.Count() > 0)
                    {
                        Job instanceJob = null;
                        Thread thread = null;
                        foreach (Type job in jobs)
                        {
                            // only instantiate the job its implementation is "real"
                            if (IsRealClass(job))
                            {
                                try
                                {
                                    // instantiate job by reflection
                                    instanceJob = (Job)Activator.CreateInstance(job);
                                    Debug.WriteLine(String.Format(
                                      "The Job \"{0}\" has been instantiated successfully.",
                                      instanceJob.GetName()));
                                    // create thread for this job execution method
                                    thread = new Thread(new ThreadStart(instanceJob.ExecuteJob));
                                    // start thread executing the job
                                        thread.Start(); 
                                    Debug.WriteLine(String.Format(
                                      "The Job \"{0}\" has its thread started successfully.",
                                      instanceJob.GetName()));
                                }
                                catch (Exception ex)
                                {
                                    Debug.WriteLine(String.Format("The Job \"{0}\" could not " +
                                      "be instantiated or executed.", job.Name), ex);
                                }
                            }
                            else
                            {
                                Debug.WriteLine(String.Format(
                                  "The Job \"{0}\" cannot be instantiated.", job.FullName));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error has occured while instantiating " +
                      "or executing Jobs for the Scheduler Framework.", ex);
                }

                Debug.WriteLine("End Method");
            }

            /// <summary>
            /// Returns all types in the current AppDomain implementing the interface or inheriting the type. 
            /// </summary>
            private IEnumerable<Type> GetAllTypesImplementingInterface(Type desiredType)
            {
                return AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                    .Where(type => desiredType.IsAssignableFrom(type));

            }

            /// <summary>
            /// Determine whether the object is real - non-abstract, non-generic-needed, non-interface class.
            /// </summary>
            /// <param name="testType">Type to be verified.</param>
            /// <returns>True in case the class is real, false otherwise.</returns>
            public static bool IsRealClass(Type testType)
            {
                return testType.IsAbstract == false
                    && testType.IsGenericTypeDefinition == false
                    && testType.IsInterface == false;
            }
        }
    }
}