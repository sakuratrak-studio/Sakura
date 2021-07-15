using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sakura.Model.Auth;

namespace Sakura.Model.Comment
{
    public class NiComment
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(CreatorId))]
        public NiUser Creator { get; set; }
        
        public string CreatorId { get; set; }
        
        public string Content { get; set; }
        
        [ForeignKey(nameof(TopicId))]
        public NiCommentTopic Topic { get; set; }
        
        public int TopicId { get; set; }
        
        [ForeignKey(nameof(RepliedToId))]
        public NiComment RepliedTo { get; set; }
        
        public int? RepliedToId { get; set; }
        
        [InverseProperty(nameof(RepliedTo))]
        public IEnumerable<NiComment> Replies { get; set; }
        
    }
}