﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Shop
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }



        [ForeignKey("Category")]
        public int Category_Id { get; set; }

        public virtual Category Category { get; set; }

    }
}
