//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStoreModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        public int SongId { get; set; }
        public Nullable<int> ArtistId { get; set; }
        public Nullable<int> AlbumId { get; set; }
        public string SongTitle { get; set; }
        public Nullable<int> SongYear { get; set; }
        public string Genre { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
