﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karnosh.Models
{
    [Index("Name", IsUnique = true)]
    public class Related
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public List<Video> ?Video { get; set; }
    }
}
