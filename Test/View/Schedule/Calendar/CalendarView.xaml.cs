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
using Test.ServiceReference;

namespace Test.View.Schedule.Calendar
{
    /// <summary>
    /// Logique d'interaction pour CalendarView.xaml
    /// </summary>
    public partial class CalendarView : UserControl
    {
        CalendarViewModel ViewModel = new CalendarViewModel();
        public CalendarView()
        {
            InitializeComponent();
            this.DataContext = ViewModel;

            //IList<Button> x1 = ViewModel.ListButton1.ToList();
            //IList<Button> x2 = ViewModel.ListButton2.ToList();
            //IList<Button> x3 = ViewModel.ListButton3.ToList();
            //IList<Button> x4 = ViewModel.ListButton4.ToList();
            //IList<Button> x5 = ViewModel.ListButton5.ToList();
            //IList<Button> x6 = ViewModel.ListButton6.ToList();
            //IList<Button> x7 = ViewModel.ListButton7.ToList();



            //ClearButtonStack();
            //AddButtonStack();


        }

        //public void AddButtonStack()
        //{
        //    foreach (Button a in ViewModel.ListButton1)
        //    {
        //        //St1.Children.Add(a);
        //    }
        //    foreach (Button a in ViewModel.ListButton2)
        //    {
        //        St2.Children.Add(a);
        //    }
        //    foreach (Button a in ViewModel.ListButton3)
        //    {
        //        St3.Children.Add(a);
        //    }
        //    foreach (Button a in ViewModel.ListButton4)
        //    {
        //        St4.Children.Add(a);
        //    }
        //    foreach (Button a in ViewModel.ListButton5)
        //    {
        //        St5.Children.Add(a);
        //    }
        //    foreach (Button a in ViewModel.ListButton6)
        //    {
        //        St6.Children.Add(a);
        //    }
        //    foreach (Button a in ViewModel.ListButton7)
        //    {
        //        St7.Children.Add(a);
        //    }
        //}

        //public void ClearButtonStack()
        //{
        //        //St1.Children.Clear();
        //        St2.Children.Clear();
        //        St3.Children.Clear();
        //        St4.Children.Clear();
        //        St5.Children.Clear();
        //        St6.Children.Clear();
        //        St7.Children.Clear();
        //}


    }
}
