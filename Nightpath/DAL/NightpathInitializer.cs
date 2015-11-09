using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Nightpath.Models;

namespace Nightpath.DAL
{
    public class NightpathInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NightpathContext>
    {
        protected override void Seed(NightpathContext context)
        {
            var Roles = new List<Role>
            {
                new Role {ID=1,Description="Administrador"},
                new Role {ID=2,Description="Client"},
                new Role {ID=3,Description="Estab_Owner"}
            };


            var Users = new List<User>
            {
              new User {Name="Ricardo",Address="Arouca",Password="1234",Email="rmaoliveira@ua.pt"}
            };

        }
    }
}