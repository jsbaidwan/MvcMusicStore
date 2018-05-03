using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Title { get; set; }

        public List<Album> Albums { get; set; }
    }
}