using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempFirstLibrary
{
    public class Demp
    {
        private string privateStr = "Baby";
        public string PublicStr = "Chinni";
        protected string ProtectedStr = "Deekshi";
        internal string InternalStr = "Saru";
        internal protected string ipStr = "Sandeep";

        void Show()
        {
            Console.WriteLine(privateStr);
            Console.WriteLine(publicStr);
            Console.WriteLine(protectedStr);
            Console.WriteLine(internalStr);
            Console.WriteLine(ipStr);

        }
    }
}
