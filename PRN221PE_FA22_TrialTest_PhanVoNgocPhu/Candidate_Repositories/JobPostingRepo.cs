using Candidate_BussinessObjects.Models;
using Candidate_Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class JobPostingRepo : IJobPostingRepo
    {
        public bool AddJobPosting(JobPosting jobPosting)
        {
            return JobPostingDAO.Instance.AddJobPosting(jobPosting);
        }

        public JobPosting GetJobPosting(string jobId) => JobPostingDAO.Instance.GetJobPosting(jobId);
        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();

        public bool RemoveJobPosting(string jobPostingId)
        {
            return JobPostingDAO.Instance.DeleteJobPosting(jobPostingId);
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            return JobPostingDAO.Instance.UpdateJobPosting(jobPosting);
        }
    }
}
