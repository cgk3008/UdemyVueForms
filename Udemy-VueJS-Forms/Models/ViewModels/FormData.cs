using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Udemy_VueJS_Forms.Models.ViewModels
{
    public class FormData
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string newsletter { get; set; }
        public string gender { get; set; }
        public string country { get; set; }

        public FormData(string n, string ln, string s, string m, string news, string gen, string ctry)
        {
            name = n;
            lastName = ln;
            subject = s;
            message = m;
            newsletter = news;
            gender = gen;
            country = ctry;
        }

    }
}