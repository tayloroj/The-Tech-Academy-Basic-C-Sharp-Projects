using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDatabaseApp;

public class StudentContext : DbContext
{
    public StudentContext() : base("name=StudentDbConnection")
    {
    }

    public DbSet<Student> Students { get; set; }
}
