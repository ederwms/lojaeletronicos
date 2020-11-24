using AutoMapper;
using Loja.Eletronicos.Dominio;
using Loja.Eletronicos.Web.ViewModels.Product;
using Loja.Eletronicos.Web.ViewModels.ProductProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Eletronicos.Web.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ProductViewModel, Product>();
            Mapper.CreateMap<ProductProviderViewModel, ProductProvider>();
        }
    }
}