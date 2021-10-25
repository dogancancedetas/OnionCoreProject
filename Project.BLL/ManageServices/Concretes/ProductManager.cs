﻿using Project.BLL.ManageServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManageServices.Concretes
{
    public class ProductManager: BaseManager<Product>, IProductManager
    {
        IProductRepository _pRep;
        public ProductManager(IProductRepository pRep): base(pRep)
        {
            _pRep = pRep;
        }
    }
}
