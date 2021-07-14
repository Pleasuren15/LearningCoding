﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace LearningCoding.Data
{
    public class AppDbContextIdentity : IdentityDbContext<IdentityUser>
    {
        public AppDbContextIdentity(DbContextOptions<AppDbContextIdentity> options) : base(options)
        {
        }

        public static async Task CreateAdmin(IConfiguration _configuration, IServiceProvider _serviceProvider)
        {
            UserManager<IdentityUser> _userManager = _serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> _roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string name = _configuration["Data:AdminUser:Name"];
            string email = _configuration["Data:AdminUser:Email"];
            string password = _configuration["Data:AdminUser:Password"];
            string role = _configuration["Data:AdminUser:Role"];

            if(await _roleManager.FindByNameAsync(role) == null)
                await _roleManager.CreateAsync(new IdentityRole(role));


            if(await _userManager.FindByNameAsync(name) == null)
            {
                IdentityUser identityUser = new IdentityUser()
                {
                    UserName = name,
                    Email = email
                };

                IdentityResult result = await _userManager.CreateAsync(identityUser, password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(identityUser, role);
                }
            }
        }
    }
}
