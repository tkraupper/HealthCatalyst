﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalyst.Models
{
    public class Person
    {
        //PRIMARY KEY
        [Key]
        [Column(TypeName = "int")]
        public int id { get; set; }

        //OTHER PROPERTIES
        [Column(TypeName = "nvarchar(50)")]
        public string firstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string lastName { get; set; }
        [Column(TypeName = "int")]
        public int age { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string interests { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string picture { get; set; }
    }
}