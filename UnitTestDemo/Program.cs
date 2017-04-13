using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechJobs.Data;

namespace UnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobData = new JobData();
            var jobs = jobData.Jobs;
        }
    }
}
