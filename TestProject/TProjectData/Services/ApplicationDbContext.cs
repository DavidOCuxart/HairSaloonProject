using System.Collections.Generic;
using TProjectData.Models;
using Microsoft.EntityFrameworkCore;


namespace TProjectData.Services;

public class ApplicationDbContext : DbContext
{
    /*public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {
    }*/

    public DbSet<User> Users { get; set; }
}
