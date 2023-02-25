using Microsoft.EntityFrameworkCore;
using ReactTest.Models;

namespace ReactTest.DbContextFile
{
    public class StudentDBContext : DbContext
    {
        IConfiguration _configuration;
        public StudentDBContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        //    public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
        //: base(options)
        //    {
        //    }
        public DbSet<Country> Country { get; set; }
       // public DbSet<Customer> Customer { get; set; }
       // public DbSet<CustomerAddress> CustomerAddress { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                #warning To protect potentially sensitive information in your connection string, you should move 
                #it out of source code.
                See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                */
                optionsBuilder.UseSqlServer("Server=DESKTOP-R1A1J4P\\SQLEXPRESS;Database=StudentDB;Trust Server Certificate=true;Trusted_Connection=True;");

            }
        }
    }







}