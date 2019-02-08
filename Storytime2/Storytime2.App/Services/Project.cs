using System;
using System.Collections.Generic;
using System.Text;

namespace Storytime2.App.Services
{
    public class Project
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public int Indent { get; set; }
        public long ItemOrder { get; set; }
        // Collapsed, Shared, IsDeleted, IsArchived, IsFavourite, IsInbox, IsTeamInbox
    }
}
