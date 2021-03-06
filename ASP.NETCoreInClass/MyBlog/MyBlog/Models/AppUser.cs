﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class AppUser : IdentityUser
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Position { get; set; }
        public string ImageName { get; set; }
    }
}
