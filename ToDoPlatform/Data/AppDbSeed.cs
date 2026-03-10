using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToDoPlatform.Models;

namespace ToDoPlatform.Data;

    public class AppDbSeed
    {
        public AppDbSeed(ModelBuilder builder)
        {
            #region  Popular Perfis de usuários
            List<IdentityRole> roles = new()
            {
                new()
                {
                    Id = "0ded8346-6067-44dd-9ad3-1cebb32b5238",
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                 new()
                {
                    Id = "b62ae884-b15c-499e-a5aa-8e06d26d3117",
                    Name = "usuário",
                    NormalizedName = "USUÁRIO"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
            #endregion

            #region  Popular  dados de Usuário
            List<AppUser> users = new()
            {
                new AppUser()
                {
                    Id = "54092b5d-b1d4-4854-8823-bfdec14b2c24",
                    Email = "anacarolinadaros@gmail.com",
                    NormalizedEmail = "ANACAROLINADAROS@GMAIL.COM",
                    UserName = "anacarolinadaros@gmail.com",
                    NormalizedUserName = "ANACAROLINADAROS@GMAIL.COM",
                    LockoutEnabled = false,
                    EmailConfirmed = true,
                    Name = "Ana Carolina Daros",
                    ProfilePicture = "/img/users/54092b5d-b1d4-4854-8823-bfdec14b2c24.png"
                },
                new AppUser()
                {
                     Id = "cd9473b6-b06d-437e-8371-6aa91ff5c38e",
                    Email = "anenoelle60@gmail.com",
                    NormalizedEmail = "ANENOELLE60@GMAIL.COM",
                    UserName = "anenoelle60@gmail.com",
                    NormalizedUserName = "ANENOELLE60@GMAIL.COM",
                    LockoutEnabled = true,
                    EmailConfirmed = true,
                    Name = "Ana Noelle",
                    ProfilePicture = "/img/users/cd9473b6-b06d-437e-8371-6aa91ff5c38e.png"
                }
                
            };
            foreach ( var user in users)
            {
                PasswordHasher<IdentityUser> pass = new();
                user.PasswordHash = pass.HashPassword(user, "123456");
            }
            builder.Entity<AppUser>().HasData(users);
            #endregion

            #region Popular Dados de Usuário Perfil
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>()
                {
                    UserId = users[0].Id,
                    RoleId = roles[0].Id
                },
                new IdentityUserRole<string>()
                {
                    UserId = users[1].Id,
                    RoleId = roles[1].Id
                },
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

            #region Popular as Tarefas do Usuário 
            List<ToDo> toDos = new()
            {
                new ToDo()
                {
                    Id = 1,
                    Title = "Estudar para Prova",
                    Description = "estudar para prova bimestral",
                    UserId = users[1].Id
                },
                new ToDo()
                {
                    Id = 2,
                    Title = "Revisar materia",
                    Description = "revisar conteudo",
                    UserId = users[0].Id
                },
                
            };
            builder.Entity<ToDo>().HasData(toDos);
            #endregion
        }
    }
