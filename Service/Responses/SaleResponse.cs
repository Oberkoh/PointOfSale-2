﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Service.Responses
{
    public class SaleResponse:BaseResponse
    {
        public CarItemSale saleItem { get; set; }
    }
}
