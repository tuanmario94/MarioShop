namespace MarioShop.Data.Migrations
{
    using MarioShop.Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MarioShop.Data.MarioShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MarioShop.Data.MarioShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MarioShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new MarioShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "mario",
            //    Email = "tuanmario94@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Tuan Mario"
            //};

            //manager.Create(user, "123456$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("tuanmario94@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
        private void CreateProductCategorySample(MarioShop.Data.MarioShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Thời Trang Nam",Alias="thoi-trang-nam",Status=true },
                 new ProductCategory() { Name="Thời Trang Nữ",Alias="thoi-trang-nu",Status=true },
                  new ProductCategory() { Name="Thời Trang Trẻ Em",Alias="thoi-trang-tre-em",Status=true },
                   new ProductCategory() { Name="Thời Trang Công Sở",Alias="thoi-trang-cong-so",Status=true }
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }

        }
    }
}
