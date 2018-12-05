using System;
using System.Collections.Generic;

namespace FarukYalcinZoo.DataAccess.Models
{
    public partial class Plants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
