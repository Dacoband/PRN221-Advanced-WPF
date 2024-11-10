using CandidateManagement_BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.Repository.Interface
{
    public interface IJobPostingRepository
    {
        Task<List<JobPosting>> GetJobPostings();
        Task<JobPosting> GetJobPostingById(int id);
        Task<JobPosting> AddJobPosting(JobPosting jobPosting);
        Task<JobPosting> UpdateJobPosting(JobPosting jobPosting);
        Task<JobPosting> DeleteJobPosting(int id);

    }
}
