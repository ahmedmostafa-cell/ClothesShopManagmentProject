﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EaglesProject.Models
{
    public class ExternalLoginConfirmationViewModel
    {
      
        [EmailAddress]
        public string Email { get; set; }

        public string Name { get; set; }
    }
}
