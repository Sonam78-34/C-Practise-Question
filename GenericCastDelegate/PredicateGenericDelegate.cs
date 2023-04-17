using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCastDelegate
{
    public class PredicateGenericDelegate
    {
        public static bool isemail(string email)
        {
            return email.Contains("@gmail.com");

        }
    }
}
