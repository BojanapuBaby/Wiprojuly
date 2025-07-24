using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamplee
{
    internal class CricketEx
    {
        static int score;

        public void Increment(int x)
        {
            score += x;
        }
    static void Main()
        {
            CricketEx fb = new CricketEx();
            CricketEx sb = new CricketEx();
            CricketEx ext = new CricketEx();


            fb.Increment(100);
            sb.Increment(200);
            ext.Increment(300);


            Console.WriteLine("Total Score " + CricketEx.score);
        }
    }
   
}
