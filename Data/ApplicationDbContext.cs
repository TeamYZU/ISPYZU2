using ISPYZU2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ISPYZU2.Areas.Identity.Pages.Account.LoginModel;

namespace ISPYZU2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<InputModel> InputModel { get; set; }
    }
}
