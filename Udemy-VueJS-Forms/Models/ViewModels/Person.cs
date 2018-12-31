﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Udemy_VueJS_Forms.Models.ViewModels
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Person(string fn, string ln)
        {
            firstName = fn;
            lastName = ln;
        }

    }
}