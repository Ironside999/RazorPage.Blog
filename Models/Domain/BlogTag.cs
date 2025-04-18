using System;

namespace practice3.Models.Domain;

public class Tag
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid BlogId { get; set; }
}
