using System;
using System.Collections.Generic;

namespace FarukYalcinZoo.DataAccess.Models
{
    public partial class Announcements
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
    }
}
