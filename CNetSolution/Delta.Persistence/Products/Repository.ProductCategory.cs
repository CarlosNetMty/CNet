﻿using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Persistence.Products
{
    public class ProductCategoryRepository : 
        Repository<ProductCategory>,
        IReadOnlyRepository<ProductCategory>,
        IRepository<ProductCategory>
    {
        public ProductCategoryRepository(Context dbContext) : base(dbContext)
        { }
        public override DbSet<ProductCategory> Store
        {
            get { return dbContext.ProductCategories; }
        }
    }
}