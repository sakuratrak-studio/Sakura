using System.ComponentModel.DataAnnotations;

namespace Sakura.Model.Comment
{
    public class NiCommentTopic
    {
        [Key]
        public int Id { get; set; }
        
        public string RelatedUrl { get; set; }
    }
}