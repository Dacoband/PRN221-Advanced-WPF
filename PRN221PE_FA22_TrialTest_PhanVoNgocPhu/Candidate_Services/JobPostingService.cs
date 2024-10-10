using Candidate_BussinessObjects.Models;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepo _jobPostingRepo;
        public JobPostingService() 
        {
            _jobPostingRepo = new JobPostingRepo();
        }

        public bool AddJobPosting(JobPosting jobPosting)
        {
            return _jobPostingRepo.AddJobPosting(jobPosting);
        }

        public JobPosting GetJobPosting(string jobId)
        {
            return _jobPostingRepo.GetJobPosting(jobId);
        }

        public List<JobPosting> GetJobPostings()
        {
            return _jobPostingRepo.GetJobPostings();
        }

        public bool RemoveJobPosting(string jobPostingId)
        {
            return _jobPostingRepo.RemoveJobPosting(jobPostingId);
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            return _jobPostingRepo.UpdateJobPosting(jobPosting);
        }
    }
}
