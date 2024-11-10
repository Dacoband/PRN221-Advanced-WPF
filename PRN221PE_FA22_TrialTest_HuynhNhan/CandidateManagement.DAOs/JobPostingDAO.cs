using CandidateManagement_BussinessObject;
using CandidateManagement_BussinessObject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.DAOs
{
    public class JobPostingDAO
    {
        private readonly CandidateManagementContext _context;
        private static JobPostingDAO _instance;
        private JobPostingDAO()
        {
            _context = new CandidateManagementContext();
        }
        public static JobPostingDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JobPostingDAO();
                }
                return _instance;
            }
        }
        public async Task<List<JobPosting>> GetJobPostings()
        {
            return await _context.JobPostings.ToListAsync();
        }
        public async Task<JobPosting> GetJobPostingById(int id)
        {
            return await _context.JobPostings.FindAsync(id);
        }
        public async Task<JobPosting> AddJobPosting(JobPosting jobPosting)
        {
            _context.JobPostings.Add(jobPosting);
            await _context.SaveChangesAsync();
            return jobPosting;
        }
        public async Task<JobPosting> UpdateJobPosting(JobPosting jobPosting)
        {
            _context.Entry(jobPosting).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return jobPosting;
        }
        public async Task<JobPosting> DeleteJobPosting(int id)
        {
            var jobPosting = await _context.JobPostings.FindAsync(id);
            if (jobPosting == null)
            {
                return null;
            }
            _context.JobPostings.Remove(jobPosting);
            await _context.SaveChangesAsync();
            return jobPosting;
        }
    }
}
