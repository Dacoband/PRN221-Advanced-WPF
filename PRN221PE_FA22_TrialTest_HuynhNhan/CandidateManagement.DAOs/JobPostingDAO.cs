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

    }
}
