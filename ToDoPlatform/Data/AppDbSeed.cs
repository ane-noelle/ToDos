using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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

            #region  Popular Usuário

            #endregion
        }
    }
