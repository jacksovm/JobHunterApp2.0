using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using JobHunterApp.Models;
using Owin;
using System.Security.Claims;

[assembly: OwinStartupAttribute(typeof(JobHunterApp.Startup))]
namespace JobHunterApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        // Create default User roles and Admin user for login   
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // Creating Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))
            {

                // Create Admin role  
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "Admin";
                user.Email = "Admin@gmail.com";

                string userPWD = "1Password!";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                }
            }

            // Creating Business role    
            if (!roleManager.RoleExists("Business"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Business";
                roleManager.Create(role);

            }

            // Creating Job-Hunter role    
            if (!roleManager.RoleExists("Job-Hunter"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Job-Hunter";
                roleManager.Create(role);

            }
        }
    }
}
