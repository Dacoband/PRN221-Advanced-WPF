using CandidateManagement.DAOs;
using CandidateManagement.Repository.Interface;
using CandidateManagement_BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.Repository
{
    public class JobPostingRepository : IJobPostingRepository
    {
        public async Task<List<JobPosting>> GetJobPostings()
        {
            return await JobPostingDAO.Instance.GetJobPostings();
        }
        public async Task<JobPosting> GetJobPostingById(int id)
        {
            return await JobPostingDAO.Instance.GetJobPostingById(id);
        }
        public async Task<JobPosting> AddJobPosting(JobPosting jobPosting)
        {
            return await JobPostingDAO.Instance.AddJobPosting(jobPosting);
        }
        public async Task<JobPosting> UpdateJobPosting(JobPosting jobPosting)
        {
            return await JobPostingDAO.Instance.UpdateJobPosting(jobPosting);
        }
        public async Task<JobPosting> DeleteJobPosting(int id)
        {
            return await JobPostingDAO.Instance.DeleteJobPosting(id);
        }
    }
}
