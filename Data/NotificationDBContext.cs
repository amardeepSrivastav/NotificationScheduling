using System;
using Microsoft.EntityFrameworkCore;
using NotificationSchedulingAPI.Models;
namespace NotificationSchedulingAPI.Data
{
    public class NotificationDBContext :DbContext
    {
        public NotificationDBContext(DbContextOptions<NotificationDBContext> opt):base(opt)
        {}
        public DbSet<Company> Companies{get;set;}
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Market> Markets{get;set;}
        public DbSet<Notification> Notifications{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853b",
                    CompanyName = "Company1",
                    CompanyNumber = 2022030601,
                    CompanyTypeId = 1,
                    MarketId     = 1
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853c",
                    CompanyName = "Company2",
                    CompanyNumber = 2022030602,
                    CompanyTypeId = 1,
                    MarketId     = 1
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853d",
                    CompanyName = "Company3",
                    CompanyNumber = 2022030603,
                    CompanyTypeId = 2,
                    MarketId     = 2
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853e",
                    CompanyName = "Company4",
                    CompanyNumber = 2022030604,
                    CompanyTypeId = 2,
                    MarketId     = 2
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853f",
                    CompanyName = "Company5",
                    CompanyNumber = 2022030605,
                    CompanyTypeId = 3,
                    MarketId     = 3
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b84785g",
                    CompanyName = "Company6",
                    CompanyNumber = 2022030606,
                    CompanyTypeId = 3,
                    MarketId     = 3
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853h",
                    CompanyName = "Company7",
                    CompanyNumber = 2022030607,
                    CompanyTypeId = 3,
                    MarketId     = 4
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853i",
                    CompanyName = "Company8",
                    CompanyNumber = 2022030608,
                    CompanyTypeId = 2,
                    MarketId     = 4
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853j",
                    CompanyName = "Company9",
                    CompanyNumber = 2022030609,
                    CompanyTypeId = 1,
                    MarketId     = 4
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853k",
                    CompanyName = "Company10",
                    CompanyNumber = 2022030610,
                    CompanyTypeId = 2,
                    MarketId     = 1
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853l",
                    CompanyName = "Company11",
                    CompanyNumber = 2022030611,
                    CompanyTypeId = 3,
                    MarketId     = 1
                },
                new Company{
                    CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853m",
                    CompanyName = "Company12",
                    CompanyNumber = 2022030612,
                    CompanyTypeId = 3,
                    MarketId     = 2
                }

            );

            modelBuilder.Entity<CompanyType>().HasData(
                new CompanyType{CompanyTypeId=1,CompanyTypeName="small"},
                new CompanyType{CompanyTypeId=2,CompanyTypeName="medium"},
                new CompanyType{CompanyTypeId=3,CompanyTypeName="large"}
            );
            modelBuilder.Entity<Market>().HasData(
                new Market{MarketId=1,MarketName="Denmark"},
                new Market{MarketId=2,MarketName="Norway"},
                new Market{MarketId=3,MarketName="Sweden"},
                new Market{MarketId=4,MarketName="FinLand"}
            );
        }
    }
}