using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonTest2
{
    public enum RW
    {
        Read, Write
    }

    public class TestClass
    {

        public RW ReadOrWrite { get; set; }
    }
}
