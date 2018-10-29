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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //CarDependency" 라는 리소스 검색
            CarDependencyProperty dpSample = TryFindResource("CarDependency") as CarDependencyProperty;
            MessageBox.Show(dpSample.MyCar);
        }
    }

    public class CarDependencyProperty : DependencyObject
    {
        //Register Dependency Property  
        public static readonly DependencyProperty CarDependency = DependencyProperty.Register("MyProperty", typeof(string), typeof(CarDependencyProperty));
        public string MyCar
        {
            get
            {
                return (string)GetValue(CarDependency);
            }
            set
            {
                SetValue(CarDependency, value);
            }
        }
    }

}
