﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class About
    {
        [Key] //Gerekli componentleri eklemeye yarar
        public int AboutID { get; set; }

        public string AboutDetails1 { get; set; }

        public string AboutDetails2 { get; set; }

        public string AboutImage1 { get; set; }

        public string AboutImage2 { get; set; }

        public string AboutMapLocation { get; set; }

        public bool AboutStatus { get; set; }
    }
}
