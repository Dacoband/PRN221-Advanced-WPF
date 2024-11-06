using CandidateManagement_BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.Repository.Interface
{
    public interface IHRAccountRepository
    {
        public Hraccount GetAccount(string email, string password);
    }
}
