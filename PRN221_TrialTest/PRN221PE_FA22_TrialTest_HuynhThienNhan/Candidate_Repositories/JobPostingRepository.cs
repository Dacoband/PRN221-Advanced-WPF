using Candidate_BusinessObjects.Models;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class JobPostingRepository : IJobPostingRepository
    {
        private readonly CandidateManagementContext _context = new CandidateManagementContext();
        public bool AddJobPosting(JobPosting jobPosting) => JobPostingDao.Instance.AddJobPosting(jobPosting);


        public JobPosting GetJobPosting(string postingId) => JobPostingDao.Instance.GetJobPosting(postingId);


        public bool UpdateJobPosting(JobPosting jobPosting) => JobPostingDao.Instance.UpdateJobPosting(jobPosting);


        public bool DeleteJobPosting(string postingId) =>
            JobPostingDao.Instance.DeleteJobPosting(postingId);

        public List<JobPosting> GetAllJobPostings()
        {
            
            return _context.JobPostings.ToList();
        }
    }


}
