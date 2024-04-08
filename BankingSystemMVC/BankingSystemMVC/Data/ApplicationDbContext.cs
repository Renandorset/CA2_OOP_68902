using BankingSystemMVC.Models;
using Microsoft.EntityFrameworkCore;
//Renan Barbosa 68902;


namespace BankingSystemMVC.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { 
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
