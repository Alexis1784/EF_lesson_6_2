﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_2
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Company Company { get; set; }
    }
}