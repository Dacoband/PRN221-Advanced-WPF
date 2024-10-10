using Candidate_BussinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Daos
{
    public class HRAccountDAO
    {
        private CandidateManagementContext HRcontext;
        private static HRAccountDAO instance = null;

        public static HRAccountDAO Instance { 
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }

        public HRAccountDAO() 
        { 
            HRcontext = new CandidateManagementContext();
        }
        public Hraccount GetHraccount(string email)
        {
            return HRcontext.Hraccounts.SingleOrDefault(m => m.Email.Equals(email));
        }
    }
}
