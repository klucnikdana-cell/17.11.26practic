using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _17._11._26_practic_
{
    internal class Album
    {
        public string NameAlbum { get; set; }
        public string NameArtist { get; set; }
        public int Graduation { get; set; }
        public double Time { get; set; }
        public int ReleaseStudio { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();

        public override string ToString()
        {
             return $"Album: {NameAlbum}\nArtist: {NameArtist}\nYear: {Graduation}" +
                $"\nDuration: {Time}\nStudio: {ReleaseStudio}";
        }
    }
}
