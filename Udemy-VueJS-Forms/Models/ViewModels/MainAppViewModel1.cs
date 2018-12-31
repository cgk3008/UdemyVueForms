using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Udemy_VueJS_Forms.Models.ViewModels
{
    public class MainAppViewModel1
    {
        public Person person {  get; set; }

        public MainAppViewModel1()
        {
            person = new Person("Jane", "fonda");
        }
    }
}