using Candidate_BusinessObjects.Models;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class HRAccountRepo : IHRAccountRepo
    {
        public Hraccount GetHraccount(string email, string password) => HRAccountDAO.Instance.GetHraccount(email, password);
    }
}
