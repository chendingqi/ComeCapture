using ScreenShot;
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
using System.Windows.Shapes;

namespace ComeCapture
{
    /// <summary>
    /// test.xaml 的交互逻辑
    /// </summary>
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();
            DataContext = new ScreenShot.AppModel();
            MaxWindow();
        }
        #region 全屏+置顶
        private void MaxWindow()
        {
            Left = 0;
            Top = 0;
            Width = ScreenUi.ScreenWidth;
            Height = ScreenUi.ScreenHeight;
            Activate();
        }
        #endregion

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }
    }
}
