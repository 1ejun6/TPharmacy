using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Server.Models;

namespace TPharmacy.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102s1",
                Email = "june@gmail.com",
                NormalizedEmail = "JUNE@GMAIL.COM",
                FirstName = "June",
                LastName = "Staff",
                UserName = "june@gmail.com",
                NormalizedUserName = "JUNE@GMAIL.COM",
                PhoneNumber = "9273 8983",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "TPharmacy",
                Password = "June1234*",
                PasswordHash = hasher.HashPassword(null, "June1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102s2",
                Email = "woon@gmail.com",
                NormalizedEmail = "WOON@GMAIL.COM",
                FirstName = "Woon",
                LastName = "Staff",
                UserName = "woon@gmail.com",
                NormalizedUserName = "WOON@GMAIL.COM",
                PhoneNumber = "9287 2324",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "TPharmacy",
                Password = "P@ssword1",
                PasswordHash = hasher.HashPassword(null, "Woon1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102s3",
                Email = "kate@gmail.com",
                NormalizedEmail = "KATE@GMAIL.COM",
                FirstName = "Kate",
                LastName = "Staff",
                UserName = "kate@gmail.com",
                NormalizedUserName = "KATE@GMAIL.COM",
                PhoneNumber = "6329 9823",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "TPharmacy",
                Password = "Kate1234*",
                PasswordHash = hasher.HashPassword(null, "Kate1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102c1",
                Email = "james@gmail.com",
                NormalizedEmail = "JAMES@GMAIL.COM",
                FirstName = "James",
                LastName = "Customer",
                UserName = "james@gmail.com",
                NormalizedUserName = "JAMES@GMAIL.COM",
                PhoneNumber = "8211 7319",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "Tampines Ave 1",
                Password = "James1234*",
                PasswordHash = hasher.HashPassword(null, "James1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102c2",
                Email = "alice@gmail.com",
                NormalizedEmail = "ALICE@GMAIL.COM",
                FirstName = "Alice",
                LastName = "Customer",
                UserName = "alice@gmail.com",
                NormalizedUserName = "ALICE@GMAIL.COM",
                PhoneNumber = "8329 7433",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "Bedok Ave 1",
                Password = "Alice1234*",
                PasswordHash = hasher.HashPassword(null, "Alice1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102c3",
                Email = "sheila@gmail.com",
                NormalizedEmail = "SHEILA@GMAIL.COM",
                FirstName = "Sheila",
                LastName = "Customer",
                UserName = "sheila@gmail.com",
                NormalizedUserName = "SHEILA@GMAIL.COM",
                PhoneNumber = "9436 7238",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "Jurong Ave 1",
                Password = "Sheila1234*",
                PasswordHash = hasher.HashPassword(null, "Sheila1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            });
        }
    }
}

