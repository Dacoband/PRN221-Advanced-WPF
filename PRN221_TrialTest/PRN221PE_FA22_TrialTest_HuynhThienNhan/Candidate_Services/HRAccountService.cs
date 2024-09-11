using Candidate_BusinessObjects.Models;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo iAccountRepo = null;
        public HRAccountService()
        {
            if (iAccountRepo == null) 
            { 
                iAccountRepo = new HRAccountRepo();
            }
        }
       
        public Hraccount GetHraccount(string email, string password)
        {
            return iAccountRepo.GetHraccount(email, password);
        }
    }
}
