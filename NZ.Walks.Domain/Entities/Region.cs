﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Walks.Domain.Entities
{
    public class Region
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        private string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
