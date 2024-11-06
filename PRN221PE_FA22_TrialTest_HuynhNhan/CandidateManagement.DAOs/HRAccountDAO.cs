using CandidateManagement_BussinessObject;
using CandidateManagement_BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.DAOs
{
    public class HRAccountDAO
    {
        private readonly CandidateManagementContext _context;
       
        private static HRAccountDAO _instance = null;
        private HRAccountDAO()
        {
            _context = new CandidateManagementContext();
        }
        public static HRAccountDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HRAccountDAO();
                }
                return _instance;
            }
        }

        public Hraccount GetAccount(string email, string password)
        {
            return _context.Hraccounts.SingleOrDefault(a => a.Email == email && a.Password == password);
        }

    }
}
