﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Troot.Model;
using Troot.Model.Product;
using Troot.Service.Product;

namespace Troot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        //Ürün listeleme
        [HttpGet]
        public General<ProductViewModel> GetProducts()
        {
            return productService.GetProducts();
        }

        //Ürün listeleme(Get By Id)
        [HttpGet("{Id}")]
        public General<ProductViewModel> GetProductListById(int id, ProductViewModel product)
        {
            return productService.GetProductListById(id, product);
        }

        //Ürün ekleme
        [HttpPost("Insert")]
        public General<ProductViewModel> InsertProduct([FromBody] ProductViewModel newProduct)
        {
            return productService.InsertProduct(newProduct);
        }

        //Ürün güncelleme
        [HttpPut("{id}")]
        public General<ProductViewModel> UpdateProduct(int id, [FromBody] ProductViewModel product)
        {
            return productService.UpdateProduct(id, product);
        }

        //Ürün silme
        [HttpPost("Delete")]
        public General<ProductViewModel> DeleteProduct(int id, [FromBody] ProductViewModel product)
        {
            return productService.DeleteProduct(id, product);
        }

    }
}