using System;
using System.Collections.Generic;

namespace Storytime2.App.Services
{
    public class Item
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ProjectId { get; set; }
        public string Content { get; set; }
        public List<long> Labels { get; set; }

        public int Priority { get; set; }
        public int ItemOrder { get; set; }
        public int Indent { get; set; }
    }
}
