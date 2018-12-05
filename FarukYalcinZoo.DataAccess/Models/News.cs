using System;
using System.Collections.Generic;

namespace FarukYalcinZoo.DataAccess.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public string Title { get; set; }
    }
}
