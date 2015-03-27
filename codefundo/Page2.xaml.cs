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
using Microsoft.Phone.Controls;

namespace codefundo
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }


        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hyperlinkButton3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.RemoveBackEntry();
        }
    }
}