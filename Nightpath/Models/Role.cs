﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightpath.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}