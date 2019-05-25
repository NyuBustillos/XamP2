﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xam.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
