﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerceApp.Models.ApiViewModels
{
    public class ProductDto
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public byte[] Image { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}