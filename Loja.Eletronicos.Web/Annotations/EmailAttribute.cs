﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loja.Eletronicos.Web.Annotations
{
    public class EmailAttribute : ValidationAttribute
    {
        public override bool IsValid (object value)
        {
            return value.ToString().EndsWith("@loja.com.br");
        }
    }
}