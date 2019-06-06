using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCEntityLogin.Models
{
    public class DBEntity : DbContext
    {
        public DbSet<tblUser> tblUsers { get; set; }
    }
}