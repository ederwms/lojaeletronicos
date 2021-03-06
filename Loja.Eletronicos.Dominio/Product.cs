﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Eletronicos.Dominio
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int QuantityInStock { get; set; }
        public virtual List<ProductProvider> Providers { get; set; }
    }
}
