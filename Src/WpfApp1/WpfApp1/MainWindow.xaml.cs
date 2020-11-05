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
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            bool rlt = RunTest();
            string outStr= "Result is " + rlt;
            MessageBox.Show(outStr);
        }
        public bool RunTest()
        {
            bool rlt = false;

            int a = 0;
            int b = 1;

            int c = SumXY(b, a);

            if (c == 1)
                rlt = true;

            return rlt;
        }
        int SumXY(int i, int i1)
        {
            int i2 = i + i1;
            return i2;
        }

        private void Click_Show_DeviceInfo(object sender, RoutedEventArgs e)
        {
            DeviceManager deviceManager = new DeviceManager();
            deviceManager.showInfo();
        }
    }
}
