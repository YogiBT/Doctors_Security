﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
  
    public class UserTerm
    {
        [Key]
        [Required]
        public string UserTerms { get; set; }
    }
}