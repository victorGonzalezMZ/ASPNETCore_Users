using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNETCoreMVC.Models;

namespace ASPNETCoreMVC.Data
{
    public class ASPNETCoreMVC_UserContext : DbContext
    {
        public ASPNETCoreMVC_UserContext (DbContextOptions<ASPNETCoreMVC_UserContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCoreMVC.Models.User> User { get; set; }
    }
}
