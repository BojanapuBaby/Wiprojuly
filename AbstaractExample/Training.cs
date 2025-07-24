using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstaractExample
{
    internal abstract class Training
    {
        public abstract void Name();
        public abstract void Email();

        internal void Company()
        {
            throw new NotImplementedException();
        }
    }
}
