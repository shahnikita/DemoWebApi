using Autofac;
using DemoWebApi.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoWebApi.Models
{
    public class DatabaseConfig
    {
        public static void Initialize(IComponentContext componentContext)
        {
            try
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

                using (var dbContext = componentContext.Resolve<DbContext>())
                {
                    dbContext.Database.Initialize(false);
                 
                }
            }

            catch (Exception ex)
            {
             

                throw;
            }
        }
    }
}