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

namespace WPFSampleApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetValue(TestDependencyProperty, 100);
            objEmployee = new Employee()
            {
                FirstName = "John",
                LastName = "Smith"
            };

            this.DataContext = this;
        }



        public int TestDependency
        {
            get { return (int)GetValue(TestDependencyProperty); }
            set { SetValue(TestDependencyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TestDependency.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestDependencyProperty =
            DependencyProperty.Register("TestDependency", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


        public Employee objEmployee { get; set; }

        
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
