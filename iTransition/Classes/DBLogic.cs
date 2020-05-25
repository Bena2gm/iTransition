using iTransition.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTransition.Classes
{
    public class DBLogic
    {
        public List<Company> LoadCompany()
        {
            using (DBContext db = new DBContext())
            {
                List<Company> companies = db.Companies.ToList(); ;
                db.Users.Load();
                return companies;
            }
        }


    }
}
