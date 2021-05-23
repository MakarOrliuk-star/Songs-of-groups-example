using System;
using System.Collections.Generic;

namespace Songs_of_groups_example
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

    }
}
