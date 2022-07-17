using ElearningSystem.DataLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.DataLayer.Context
{
    public class ElearningContext : IdentityDbContext<ApplicationUser>
    {
        public ElearningContext(DbContextOptions<ElearningContext> options) : base(options)
        {
        }
        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<FacultyModel> facultyModels { get; set; }              
        public DbSet<AdminModel> adminModels { get; set; }
    }
}

