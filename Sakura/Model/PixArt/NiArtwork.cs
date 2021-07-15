using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sakura.Model.Auth;

namespace Sakura.Model.PixArt
{
    public class NiArtwork
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(CreatorId))]
        public NiUser Creator { get; set; }
        
        public string CreatorId { get; set; }
        
        [ForeignKey(nameof(CollectionId))]
        public NiArtworkCollection Collection { get; set; }
        public int CollectionId { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }
        
        public int Order { get; set; }
        
        public string ImageUrl { get; set; }
        
        public int ResolutionX { get; set; }
        
        public int ResolutionY { get; set; }

    }
}