using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace médiatèque.DAL
{
    internal class MotifAccess
    {
        private readonly Access access = null!;

        public MotifAccess()
        {
            access = Access.GetInstance();
        }
    }
}
