using LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain;
using LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models
{
    public class UserLogin : BaseModel
    {
        public Guid? UserId { get; set; }

        public User User { get; set; }

        public LoginType Type { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
