using System;
using System.Collections.Generic;

namespace Songs_of_groups_example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext()) 
            {
                var group = new Group()
                {
                    Name = "Rammstein",
                    Year = 1994
                };

                var group2 = new Group()
                {
                    Name = "Linkin Park",
                    Year = 1996
                };

                context.Groups.Add(group);
                context.Groups.Add(group2);

                context.SaveChanges();

                var songs = new List<Song>()
                {
                    new Song() { Name = "In the end", GroupId = group2.GroupId},
                    new Song() {Name = "Numb", GroupId = group2.GroupId},
                    new Song() {Name = "Mutter", GroupId = group2.GroupId}
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach(var song in songs)
                {
                    Console.WriteLine($"song name: {song.Name}, Group name: {song.Group?.Name}");
                }
                Console.ReadLine();
            }
        }
    }
}
