using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).FullName;
        DbPath = System.IO.Path.Join(projectDirectory, "database.db");
    }

    // The following configures EF to create a MariaDB database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=db_testing;user=root", new MariaDbServerVersion(new Version(10, 6, 10)));
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}
