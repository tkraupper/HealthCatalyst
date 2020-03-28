﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalyst.Models
{
    public class HealthCatalystDBContext:DbContext
    {
        public HealthCatalystDBContext(DbContextOptions<HealthCatalystDBContext> options):base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
