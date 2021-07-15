using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sakura.Model;
using Sakura.Model.Auth;
using Sakura.Model.Comment;
using Sakura.Model.PixArt;

namespace Sakura.Data
{
    public class ApplicationDbContext : IdentityDbContext<NiUser, NiRole, string>
    {
        public DbSet<NiComment> Comments { get; set; }
        
        public DbSet<NiCommentTopic> CommentTopics { get; set; }
        
        public DbSet<NiArtwork> Artworks { get; set; }
        
        public DbSet<NiArtworkCollection> ArtworkCollections { get; set; }
        
        
        
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}