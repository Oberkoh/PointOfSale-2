﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccess
{
   public interface IUserRepository
    {
       User GetUserByUserPassword(string username,string password);
    }
}
