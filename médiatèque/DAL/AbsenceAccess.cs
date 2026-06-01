using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace médiatèque.DAL
{
    internal class AbsenceAccess
    {
        private readonly Access access = null!;

        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }
    }
}
