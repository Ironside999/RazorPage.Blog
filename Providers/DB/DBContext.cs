using System;
using Microsoft.EntityFrameworkCore;
using practice3.Models.Domain;

namespace practice3.Providers.DB;


public class DBContext(DbContextOptions options): DbContext(options)
{
    DbSet<Blog> Blogs { set; get; }
    DbSet<Tag> Tags { set; get; }
}
