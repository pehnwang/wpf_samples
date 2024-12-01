using System.Windows;
using demo01.Models;

namespace demo01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Persion Persion { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Persion = new Persion { Name = "wps" };
            DataContext = Persion; // 设置DataContext
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // 随机生成一个名字
            Persion.Name = "wps" + new Random().Next(1, 100);
        }
    }
}