﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EaglesProject.Models
{
    public class SignUpModel
    {
       
        public string FirstName { get; set; }

       
        public string LastName { get; set; }

        
        public string Email { get; set; }

       
        public string UserName { get; set; }


        public IFormFile PersonalImage { get; set; }

        public string image { get; set; }

        public string Password { get; set; }

      
    }
}
