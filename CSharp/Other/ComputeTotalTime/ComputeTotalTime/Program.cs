/*
Give an array of job objects, compute the total time needed to compute all jobs
Some have dependencies on other jobs

[
	{
		"depends": [],
		"timeNeeded": 5
	}
]
*/

using System;

namespace ComputeTotalTime
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var job1 = new Job(4, new int[] { 1, 2 });
            var job2 = new Job(3, new int[0]);
            var job3 = new Job(5, new int[0]);
            var job4 = new Job(1, new int[] { 0 });

            Job[] jobs = new Job[4];
            jobs[0] = job1;
            jobs[1] = job2;
            jobs[2] = job3;
            jobs[3] = job4;

            int res = TotalTime(jobs);
            Console.WriteLine(res);
        }

        public static int TotalTime(Job[] jobs, int time = 0, Dictionary<int[], int> jobMap = null, Dictionary<int, Job> allJobs = null, int[] curJobs = null)
        {
            if (jobs.Length == 0)
            {
                return 0;
            }

            if (allJobs == null)
            {
                allJobs = new Dictionary<int, Job>();
                for (int i = 0; i < jobs.Length; i++)
                    allJobs.Add(i, jobs[i]);
            }

            if (jobMap == null)
                jobMap = new Dictionary<int[], int>();

            if (curJobs != null && jobMap.ContainsKey(curJobs))
                return jobMap[curJobs];

            foreach (Job job in jobs)
            {
                if (job.Depends.Length > 0)
                {
                    int tmp = 0;

                    var depJobs = new Job[job.Depends.Length];
                    for (int i = 0; i < depJobs.Length; i++)
                        depJobs[i] = new Job(allJobs[job.Depends[i]].TimeNeeded, allJobs[job.Depends[i]].Depends);

                    tmp = TotalTime(depJobs, 0, jobMap, allJobs, job.Depends);

                    if (!jobMap.ContainsKey(job.Depends))
                        jobMap.Add(job.Depends, tmp);

                    time += jobMap[job.Depends];
                }
                time += job.TimeNeeded;
            }

            return time;
        }
    }

    public class Job
    {
        public int[] Depends { get; set; }
        public int TimeNeeded { get; set; }

        public Job(int time, int[] depends)
        {
            Depends = depends;
            TimeNeeded = time;
        }
    }
}
