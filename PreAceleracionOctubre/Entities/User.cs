﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAceleracionOctubre.Entities
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; }
    }
}
