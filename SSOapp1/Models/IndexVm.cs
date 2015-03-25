using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSOapp1.Models
{
    public class IndexVm
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLoginSuccessful { get; set; }
        public bool UnsuccesfullAttemptToLogin { get; set; }
    }
}