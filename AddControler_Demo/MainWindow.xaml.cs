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

namespace AddControler_Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 加个按钮
            Button button = new Button();
            button.Margin = new Thickness(0, 0, 20, 20);
            button.Height = 40;
            button.Width = 40;
            button.HorizontalAlignment = HorizontalAlignment.Right;
            button.Content = "用户";
            this.Box.Children.Add(button);
            button.Click += Manage_Click;
        }

        private void Manage_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.ShowDialog();
        }
    }
}
