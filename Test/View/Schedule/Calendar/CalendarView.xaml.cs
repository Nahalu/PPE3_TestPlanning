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


            IList<interventions> list = ViewModel.ListInterventions.ToList();

            if (list != null)
            {
                Button();

            }




        }
        public Button Button()
        {
            InitializeComponent();
            Button x = new Button();
            x.Height = 100;
            x.Width = 3000;
            x.Background = new SolidColorBrush(Colors.Purple);
            x.Content = "BONJOUR";
            St1.Children.Add(x);
            return x;
        }
    }
}
