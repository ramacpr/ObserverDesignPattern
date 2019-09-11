using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Data
{
    class JobInfo : ISubscribedData
    {
        string jobData = "";
        public JobInfo(string jobData)
        {
            this.jobData = jobData;
        }

        public string GetJobDescription()
        {
            return this.jobData;
        }

        public void SetJobDescription(string jobDesc)
        {
            this.jobData = jobDesc;
        }
    }
}
