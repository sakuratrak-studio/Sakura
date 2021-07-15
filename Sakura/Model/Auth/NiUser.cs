using System;
using Microsoft.AspNetCore.Identity;

namespace Sakura.Model.Auth
{
    public class NiUser : IdentityUser
    {
        public string Bio { get; set; }
        
        public string AvatarId { get; set; }
        
        public string NickName { get; set; }
        
        public Gender Gender { get; set; }
        
        public string Country { get; set; }
        
        public DateTimeOffset BitrthDate { get; set; }
    }
}