using LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain;
using LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.Ecommerse.Web.ViewModels.Products
{
    public class ProductSearchViewModel
    {
        public Paged<ProductViewModel> Products { get; set; }
    }
    
    public class ProductViewModel : Product
    {
    }
}