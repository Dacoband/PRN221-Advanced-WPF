﻿using CandidateManagement.DAOs;
using CandidateManagement.Repository.Interface;
using CandidateManagement_BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.Repository
{
    public class HRAccountRepository : IHRAccountRepository
    {
        public Hraccount GetAccount(string email, string password)
        {
            return HRAccountDAO.Instance.GetAccount(email, password);
        }
    }
}