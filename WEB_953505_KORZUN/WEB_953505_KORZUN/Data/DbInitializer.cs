using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WEB_953505_KORZUN.Entities;

namespace WEB_953505_KORZUN.Data
{
    public class DbInitializer
    {
        public DbInitializer()
        {
        }
        public static async Task Seed(ApplicationDbContext context,
                                       UserManager<ApplicationUser> userManager,
                                       RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();
            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                // создать роль admin
                await roleManager.CreateAsync(roleAdmin);

            }

            if (!context.Users.Any())
            {
                // создать пользователя user@mail.ru
                var user = new ApplicationUser
                {
                    Email = "user@mail.ru",
                    UserName = "user@mail.ru"
                };
                await userManager.CreateAsync(user, "123456");
                // создать пользователя admin@mail.ru
                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                await userManager.CreateAsync(admin, "123456");
                // назначить роль admin
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }
            if (!context.ProductGroups.Any())
            {
                context.ProductGroups.AddRange(
                new List<ProductGroup>
                {
                    new ProductGroup{ProductGroupId=1, GroupName="Laptops"},
                    new ProductGroup{ProductGroupId=2, GroupName="Phones"},
                    new ProductGroup{ProductGroupId=3, GroupName="Tablets"},
                    new ProductGroup{ProductGroupId=4, GroupName="Headphones"},
                    new ProductGroup{ProductGroupId=5, GroupName="TVs"}
                });
                await context.SaveChangesAsync();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new List<Product>
                {
                    new Product{ProductId = 1, ProductName="Samsung Galaxy Z Flip3",
                        Description="Android, экран 6.7 AMOLED (1080x2640), Qualcomm Snapdragon 888, ОЗУ 8 ГБ, флэш-память 256 ГБ, камера 12 Мп, аккумулятор 3300 мАч, 1 SIM",
                        Price=2840.0, ProductGroupId=2, Image="zflip.jpeg" },
                    new Product{ProductId = 2, ProductName="Apple Macbook Air 13 M1 2020",
                        Description="13.3 2560 x 1600 IPS, 60 Гц, несенсорный, Apple M1 3200 МГц, 8 ГБ, SSD 256 ГБ, видеокарта встроенная, Mac OS, цвет крышки серый",
                        Price=2749.0, ProductGroupId=1, Image="macbook.jpeg" },
                    new Product{ProductId = 3, ProductName="Apple iPad 10.2 2021 64GB",
                        Description="10.2 IPS (2160x1620), iPadOS, Apple A13 Bionic, ОЗУ 3 ГБ, флэш-память 64 ГБ, цвет темно-серый",
                        Price=1190.0, ProductGroupId=3, Image="ipad.jpeg" },
                    new Product{ProductId = 4, ProductName="Apple AirPods Pro",
                        Description="беспроводные наушники с микрофоном, внутриканальные, портативные, Bluetooth, быстрая зарядка, время работы 5 ч, с кейсом 24 ч, активное шумоподавление",
                        Price=559.0, ProductGroupId=4, Image="airpods.jpeg" },
                    new Product{ProductId = 5, ProductName="LG OLED55C1RLA",
                        Description="55 3840x2160 (4K UHD), матрица OLED, частота матрицы 120 Гц, Smart TV (LG webOS), HDR, Wi-Fi",
                        Price=3350.0, ProductGroupId=5, Image="lg.jpeg" },

                });
                await context.SaveChangesAsync();
            }

        }
    }
}
   