using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Interface_1
// определяет животное, как компаньон или источник материальных благ,
// с методами Название животного, Голос;

namespace Animals
{
    internal interface Interface_1
    {
        public bool IsComp { get;}
        public string TypeName();
    }
}
