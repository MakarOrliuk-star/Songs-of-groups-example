using System;

namespace Songs_of_groups_example
{
    public class Song
    {
        public int Songid { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

    }
}
