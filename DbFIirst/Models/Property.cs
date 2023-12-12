using System;
using System.Collections.Generic;

namespace DbFIirst.Models
{
    public partial class Property
    {
        public Guid Propid { get; set; }
        public string? Propname { get; set; }
        public string? Address { get; set; }
        public string? Purpose { get; set; }
        public decimal? Price { get; set; }
    }
}
