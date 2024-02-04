using System;

namespace Tests.Models;

public record Human(string Name, int Age)
{
    public Guid Id => Guid.NewGuid();
}
