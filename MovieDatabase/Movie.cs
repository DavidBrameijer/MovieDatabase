﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }

        //constructors
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }
    }
}
