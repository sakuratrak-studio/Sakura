using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime;
using Sakura.Model.Auth;

namespace Sakura.Model.PixArt
{
    public class NiArtworkCollection
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(20)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        
        public string Tags { get; set; }
        
        [ForeignKey(nameof(CreatorId))]
        public NiUser Creator { get; set; }
        
        public string CreatorId { get; set; }
        
        [InverseProperty(nameof(NiArtwork.Collection))]
        public IEnumerable<NiArtwork> Content { get; set; }
        
        public DateTimeOffset CreateTime { get; set; }
        
        public ArtworkCreateType CreateType { get; set; }
        
        public ArtworkAgePolice AgePolice { get; set; }
        

        public enum ArtworkCreateType
        {
            Create,
            Forward
        }

        public enum ArtworkAgePolice
        {
            All,
            Warn,
            R18
        }
    }
}