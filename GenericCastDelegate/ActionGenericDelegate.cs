using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCastDelegate
{
    public  class ActionGenericDelegate
    {
        public static void FindAInMessage(string message)
        {
            for(int i=0;i<message.Length; i++)
            {
                if (message[i] == 'a' || message[i] =='A')
                {
                    Console.WriteLine("The message contains letter A or a");
                }
            }

        }
    }
}
