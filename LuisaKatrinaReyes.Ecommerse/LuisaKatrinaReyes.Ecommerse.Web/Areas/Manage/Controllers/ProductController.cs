﻿using LuisaKatrinaReyes.Ecommerse.Web.Areas.Manage.Models;
using LuisaKatrinaReyes.Ecommerse.Web.Areas.Manage.ViewModels;
using LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain;
using LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models;
using LuisaKatrinaReyes.Ecommerse.Web.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.Ecommerse.Web.Areas.Manage.Controllers
{

    [Area("manage")]
    public class ProductsController : Controller
    {
        private readonly DefaultDbContext _context;
        public ProductsController(DefaultDbContext context)
        {
            _context = context;
        }

        //list
        //pager
        //search-keyword
        //filter
        //sort
        [HttpGet("manage/products")]
        public IActionResult Product(int pageIndex = 1,
                                    int pageSize = 10,
                                    string sortBy = "name",
                                    string sortOrder = "asc",
                                    Guid? categoryId = null,
                                    string keyword = "")
        {
            IQueryable<Product> allProducts = _context.Products.AsQueryable();
            Paged<Product> products = new Paged<Product>();

            if (categoryId != null)
            {
                allProducts = allProducts.Where(p => p.CategoryId == categoryId);

            }

            if (!string.IsNullOrEmpty(keyword))
            {
                allProducts = allProducts.Where(p => p.Name.Contains(keyword)
                                                    || p.TagLine.Contains(keyword)
                                                    || p.Description.Contains(keyword));
            }

            var queryCount = allProducts.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "name" && sortOrder.ToLower() == "asc")
            {
                products.Items = allProducts.OrderBy(e => e.Name).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "name" && sortOrder.ToLower() == "desc")
            {
                products.Items = allProducts.OrderByDescending(e => e.Name).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "price" && sortOrder.ToLower() == "asc")
            {
                products.Items = allProducts.OrderBy(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                products.Items = allProducts.OrderByDescending(e => e.Price).Skip(skip).Take(pageSize).ToList();
            }

            var result = new ProductSearchViewModel();
            result.Products = new Paged<ProductViewModel>();
            result.Products.PageCount = pageCount;
            result.Products.QueryCount = queryCount;
            result.Products.PageIndex = pageIndex;
            result.Products.PageSize = pageSize;
            result.Products.Keyword = keyword;

            if (categoryId != null)
            {
                result.Products.FilterString = "categoryId=" + categoryId.ToString();
            }

            result.Products.Items = new List<ProductViewModel>();

            foreach (var product in products.Items)
            {
                result.Products.Items.Add(new ProductViewModel()
                {
                    Id = product.Id,
                    Description = product.Description,
                    CategoryId = product.CategoryId,
                    CreatedAt = product.CreatedAt,
                    Name = product.Name,
                    Price = product.Price,
                    TagLine = product.TagLine,
                    UpdatedAt = product.UpdatedAt
                });
            }

            return View(result);
        }

        [HttpPost("/manage/products/create")]
        public IActionResult Create(CreateViewModel model)
        {
            Product product = new Product()
            {
                Id = Guid.NewGuid(),
                Description = model.Description,
                
                CategoryId = model.CategoryId,
                Name = model.Name,
                Price = model.Price,
                TagLine = model.TagLine
                
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectPermanent("/manage/products");
        }

        [HttpGet("/manage/products/AddProduct")]
        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpGet("manage/products/update/{id}")]
        public IActionResult Update(Guid? id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                //TODO : error
            }

            return View(new UpdateViewModel()
            {
                Id = product.Id,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                TagLine = product.TagLine
            });
        }



        [HttpPost("/manage/products/update")]
        public IActionResult Update(UpdateViewModel model)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == model.Id);

            if (product != null)
            {
                product.Name = model.Name;
                product.TagLine = model.TagLine;
                product.Description = model.Description;
                product.Price = model.Price;
                product.UpdatedAt = DateTime.UtcNow;

                _context.Products.Update(product);
                _context.SaveChanges();
            }
            else
            {
                //TODO: Error
            }

            return RedirectPermanent("/manage/products");

        }


        [HttpPost("/manage/products/delete")]
        public IActionResult Remove(IdViewModel model)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == model.Id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            else
            {
                //TODO: Error
            }

            return RedirectPermanent("/manage/products");

        }
    }
}
