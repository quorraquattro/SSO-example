using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSOapp2.Models
{
    public class Index2Vm
    {
        public bool IsLoginCookieExists { get; set; }
        public string UserName { get; set; }
    }
}