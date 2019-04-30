using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CameraFavorite
    {
        [Key]
        public long Id { get; set;}
        public virtual Camera Camera { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
