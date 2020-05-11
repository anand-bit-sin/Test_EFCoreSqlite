using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTest
{
    class MydbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnectionString = "";
            SqliteConnection connection = new SqliteConnection(dbConnectionString);
            optionsBuilder.UseSqlite(connection);
        }
    }
}
