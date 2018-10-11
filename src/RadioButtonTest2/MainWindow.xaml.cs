using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioButtonTest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tc = new TestClass();
            vm = new TestViewModel(tc);
        }

        private TestViewModel vm;
        private TestClass tc;

        private void test_Click(object sender, RoutedEventArgs e)
        {
            TestWindow wdn = new TestWindow(vm);
            wdn.ShowDialog();
        }
    }
}
