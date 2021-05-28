using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string TagLine { get; set; }
        public string Description { get; set; }

    }
}