﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightpath.Models
{
    public class Client:User
    {
        public int UserID { get; set; }


        public virtual User User { get; set; }
    }
}