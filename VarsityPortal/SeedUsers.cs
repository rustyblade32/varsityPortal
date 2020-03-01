using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal
{
    public static class SeedUsers
    {
        private const string Admin = "Admin";
        private const string Teacher = "Teacher";
        private const string Student = "Student";

        public static async Task Seed(
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager)
        {
            var adminRoleExists = await roleManager.RoleExistsAsync(Admin);
            if (!adminRoleExists)
            {
                var role = new IdentityRole { Name = Admin };
                await roleManager.CreateAsync(role);

                //Here we create a Admin super user who will maintain the website
                var user = new IdentityUser
                {
                    UserName = "admin@portal.com",
                    Email = "admin@portal.com",
                    EmailConfirmed = true
                };

                const string userPwd = "Pwd+123";

                var chkUser =
                    await userManager.CreateAsync(
                        user,
                        userPwd);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    await userManager.AddToRoleAsync(
                        user,
                        Admin);
                }
            }

            var studentRoleExists =
                await roleManager.RoleExistsAsync(Student);
            if (!studentRoleExists)
            {
                var role = new IdentityRole { Name = Student };
                await roleManager.CreateAsync(role);
            }

            var teacherRoleExists =
                await roleManager.RoleExistsAsync(Teacher);

            if (!teacherRoleExists)
            {
                var role = new IdentityRole { Name = Teacher };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
