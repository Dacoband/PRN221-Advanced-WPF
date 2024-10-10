using Candidate_BussinessObjects.Models;
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
        private IHRAccountRepo _iAccountRepo;
        public HRAccountService() { 
            _iAccountRepo = new HRAccountRepo();
        }
        public Hraccount GetHraccount(string email)
        {
            return _iAccountRepo.GetHraccount(email);
        }
    }
}
