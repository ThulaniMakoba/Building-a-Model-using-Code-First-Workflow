using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst
{
    class Program
    {
        public class Video
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime ReleaseDate { get; set; }
            public Genre Genres { get; set; }
            public Classification Classification { get; set; }
        }
        public class Genre
        {
            public byte Id { get; set; }
            public string Name { get; set; }
            public Collection<Video> Videos { get; set; }
        }
        public class VidzyContext:DbContext
        {
            public DbSet<Video> Videos { get; set; }
            public DbSet<Genre> Genres { get; set; }

            public VidzyContext() : base("name=VidzyContext")
            {
                
            }
        }

        public enum Classification
        {
            Silver = 1,
            Gold = 2,
            Platinum = 3
        }
        static void Main(string[] args)
        {
        }
    }
}
