using Candidate_BussinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Daos
{
    public class JobPostingDAO
    {
        private CandidateManagementContext context;
        private static JobPostingDAO instance;
        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }

        }
        public JobPostingDAO() 
        { 
            context = new CandidateManagementContext();
        }
        public bool AddJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            try
            {
                context.JobPostings.Add(jobPosting);
                context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                //Write log
            }

            return isSuccess;
        }
        public JobPosting GetJobPosting(string jobId)
        {
            return context.JobPostings.SingleOrDefault(j => j.PostingId.Equals(jobId));
        }
        public List<JobPosting> GetJobPostings() 
        { 
            return context.JobPostings.ToList();
        }
        public bool UpdateJobPosting (JobPosting jobPosting)
        {
            bool isSuccess = false;
            try
            {
                JobPosting jobPost = GetJobPosting(jobPosting.PostingId);
                if (jobPost != null)
                {
                    context.JobPostings.Update(jobPosting);
                    context.SaveChanges();
                    context.Entry(jobPosting).State = EntityState.Detached;
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            return isSuccess;
        }
        public bool DeleteJobPosting(string jobPostingId)
        {
            bool isSuccess = false;
            try
            {
                JobPosting jobPost = GetJobPosting(jobPostingId);
                if (jobPost != null)
                {
                    context.JobPostings.Remove(jobPost);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            return isSuccess;
        }
    }
}
