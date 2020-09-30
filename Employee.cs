using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class  Employee<T>
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

    }
}
