using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SQA
{
    public partial class MainPage : UserControl
    {
        ServiceReference1.WebService1SoapClient myService;

        public MainPage()
        {
            InitializeComponent();
            myService = new ServiceReference1.WebService1SoapClient();
            myService.ExecuteScalarCompleted += myService_ExecuteScalarCompleted;
            myService.ExecuteNonQueryCompleted += myService_ExecuteNonQueryCompleted;

        }
        void myService_ExecuteNonQueryCompleted(object sender,
                   ServiceReference1.ExecuteNonQueryCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        void myService_ExecuteScalarCompleted(object sender,
             ServiceReference1.ExecuteScalarCompletedEventArgs e)
        {
            textBox1.Text=e.Result;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            myService.ExecuteScalarAsync(textBox1.Text);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myService.ExecuteScalarAsync(textBox1.Text);
        }
    }
}
