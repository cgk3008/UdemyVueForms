using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Udemy_VueJS_Forms.Models.ViewModels
{
    public class MainAppViewModel1
    {
        public MainAppViewModel1()
        {
            person = new Person("Jane", "fonda", "cgk@gmail.com");

            formdata = new FormData("enter name", "enter lastname come on!!!!", "enter subject", "enter message", "enter newsletter", "enter gender", "enter country");
        }

        public FormData formdata { get; set; }
        public Person person { get; set; }
    }
}