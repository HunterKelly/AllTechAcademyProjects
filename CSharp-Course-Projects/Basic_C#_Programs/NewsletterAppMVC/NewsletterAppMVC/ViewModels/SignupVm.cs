using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMVC.ViewModels
{
    public class SignupVm
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
}