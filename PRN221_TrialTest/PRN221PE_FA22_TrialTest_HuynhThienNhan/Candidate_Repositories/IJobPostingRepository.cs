﻿using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public interface IJobPostingRepository
    {
        public bool AddJobPosting(JobPosting jobPosting);


        public bool UpdateJobPosting(JobPosting jobPosting);


        public JobPosting GetJobPosting(string postingId);

        public bool DeleteJobPosting(string postingId);
        public List<JobPosting> GetAllJobPostings();

    }

}
