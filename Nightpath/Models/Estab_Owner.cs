using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightpath.Models
{
    public class Estab_Owner : ApplicationUser
    {
        public int UserID { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Establishment> Establishment { get; set; }


    }

}