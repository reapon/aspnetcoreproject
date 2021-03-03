﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashraful_CoreProject.ViewModels
{
    public class OrderMastViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderDetlViewModel> OrderDetlViewModel { get; set; }
    }
}
