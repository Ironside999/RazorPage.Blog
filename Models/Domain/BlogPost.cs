using System;

namespace practice3.Models.Domain;

public class Blog
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}
