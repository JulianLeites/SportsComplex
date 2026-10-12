using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
namespace Infrastructure;
public class ApplicationDbContext
{
    public List<User> Users { get; } =
    [
    new User
        {
            Id = 1,
            FirstName = "Julian",
            LastName = "Leites",
            Email = "julilei276@gmail.com",
            PasswordHash = "ABC",
            PhoneNumber = "3413568332",
            DNI = 46654276,
            CreatedAt = new DateTime(2026, 10, 12),
        },
    ];

}
