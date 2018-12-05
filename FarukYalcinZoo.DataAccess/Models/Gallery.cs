using System;
using System.Collections.Generic;

namespace FarukYalcinZoo.DataAccess.Models
{
    public partial class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Group { get; set; }
    }
}
