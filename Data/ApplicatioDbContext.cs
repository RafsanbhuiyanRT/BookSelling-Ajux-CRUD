using BookSelling_E_Comerse.Models;
using BookSelling_E_Comerse.Models.EmployFile;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace BookSelling_E_Comerse.Data;

public class ApplicatioDbContext:DbContext
{
    public ApplicatioDbContext(DbContextOptions<ApplicatioDbContext> options):base(options)
    {
        
    }
    public DbSet<Category>  Categorys { get; set; }
    public DbSet<Product>  Products { get; set; }
    public DbSet<House>  House { get; set; }
    public DbSet<Collage> Collage { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<EmployList> EmployList { get; set; }
    public DbSet<EmpDepartment> EmpDepartment { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmpDepartment>().HasData(
            new EmpDepartment {DepartmentId = 1,   DepartmentName = "Sales" },
                 new EmpDepartment {DepartmentId = 2,   DepartmentName = "Marketing" },
                 new EmpDepartment {DepartmentId = 3,   DepartmentName = "Finance" },
                 new EmpDepartment {DepartmentId = 4,   DepartmentName = "Human Resources" },
                 new EmpDepartment {DepartmentId = 5,   DepartmentName = "Information Technology" }

            );

    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Category>().HasData(
    //        new Category { Id = 1, Name = "Action", DisplayOreder = "5" },
    //             new Category { Id = 2, Name = "Program", DisplayOreder = "3" },
    //             new Category { Id = 3, Name = "History", DisplayOreder = "2" }
    //        );
    //}

    //protected override void OnModelCreating (ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<House>().HasData(
    //        new House { HouseNumber = "3453", City = "Dhaka" , Name= "Bnagladesh Bank"},
    //        new House { HouseNumber = "3553", City = "Comilla" , Name= "Bnagladesh Bank"},
    //        new House { HouseNumber = "3653", City = "Borishal" , Name= "Bnagladesh Bank"}
    //        );
    //}
}
