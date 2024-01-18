using Microsoft.EntityFrameworkCore;
using StudiesEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesEF.Data
{
    public class StudiesEFDataContext : DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<PostTag> PostTags{ get; set; }
        public DbSet<Role> Roles{ get; set; }
        public DbSet<Tag> Tags{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserRole> UserRolers{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=MARCOS-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");   
        
    }
}
