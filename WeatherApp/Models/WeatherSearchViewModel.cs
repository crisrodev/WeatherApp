﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherSearchViewModel
    {
        [Required]
        public string City { get; set; }

        public WeatherViewModel Result { get; set; }
    }
}
