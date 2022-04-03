using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspTemplate.Areas.Identity.Data;
using AspTemplate.Models;

namespace AspTemplate.Areas.Identity.Data
{
	public class AspTemplateContext : IdentityDbContext<AspTemplateUser>
	{
        public AspTemplateContext(DbContextOptions<AspTemplateContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

