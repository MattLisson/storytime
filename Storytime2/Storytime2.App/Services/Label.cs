using System;
using System.Collections.Generic;
using System.Text;

namespace Storytime2.App.Services
{
    public class Label
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public int ItemOrder { get; set; }

        // IsDeleted, IsFavourite
    }
}
