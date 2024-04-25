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

namespace OnetToTen
{
    /// <summary>
    /// Interaction logic for SumEven.xaml
    /// </summary>
    public partial class SumEven : Window
    {
        public SumEven()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i= 2; i<=20; i+=2)
            {
                sum += i;
            }
            sumTextBlock.Text = sum.ToString();
        }

       
    }

}