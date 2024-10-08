﻿using Candidate_BusinessObjects.Models;
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
        private IJobPostingRepository jobPostingRepository = null;

        public JobPostingService()
        {
            if (jobPostingRepository == null)
            {
                jobPostingRepository = new JobPostingRepository();
            }
        }

        public bool AddJobPosting(JobPosting jobPosting)
        {
            return jobPostingRepository.AddJobPosting(jobPosting);
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            return jobPostingRepository.UpdateJobPosting(jobPosting);
        }

        public JobPosting GetJobPosting(string postingId)
        {
            return jobPostingRepository.GetJobPosting(postingId);
        }
        public bool DeleteJobPosting(string postingId)
        {
            return jobPostingRepository.DeleteJobPosting(postingId);
        }
         public List<JobPosting> GetJobPostings()
    {
        return jobPostingRepository.GetAllJobPostings(); // Assuming you have a repository method for this
    }
    }

}
