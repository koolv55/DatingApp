using System;

namespace DatingApp.Entities;

public class AppUser
{
    public string Id { get; set; } = new Guid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
}
