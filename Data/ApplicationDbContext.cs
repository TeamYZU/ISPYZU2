using ISPYZU2.Areas.Identity.Data;
using ISPYZU2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ISPYZU2.Areas.Identity.Pages.Account.LoginModel;

namespace ISPYZU2.Data
{
    /*
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<InputModel> AuthLogin { get; set; }
    }
    */

    public class ApplicationDbContext : IdentityDbContext<ISPYZU2User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<InputModel> AuthLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
