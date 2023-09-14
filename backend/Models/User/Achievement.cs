using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameAppBackend.Models;

namespace backend.Models.User
{
    public class Achievement
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        
    }
}