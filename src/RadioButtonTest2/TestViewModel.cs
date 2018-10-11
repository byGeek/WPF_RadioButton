using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonTest2
{
    public class TestViewModel : ViewModelBase
    {
        private readonly TestClass testclass;
        public TestViewModel(TestClass tc)
        {
            testclass = tc;
        }

        public bool IsRead
        {
            get { return testclass.ReadOrWrite == RW.Read; }
            set
            {
                testclass.ReadOrWrite = value ? RW.Read : RW.Write;
                OnPropertyChanged("IsRead");
            }
        }

        public bool IsWrite
        {
            get { return testclass.ReadOrWrite == RW.Write; }
            set
            {
                testclass.ReadOrWrite = value ? RW.Write : RW.Read;
                OnPropertyChanged("IsWrite");
            }
        }
    }
}
