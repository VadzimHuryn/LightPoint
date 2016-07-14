using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day5WebApiHomework.Models
{
    public class User:IdentityUser
    {
        public virtual ICollection<Place> Places { get; set; }
        public User()
        {
            Places = new HashSet<Place>();
        }
    }
}
