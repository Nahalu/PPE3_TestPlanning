using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.View.Schedule.Calendar
{
    class CalendarViewModel : ObservableObject, IPageViewModel
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public DateTime Date1 { get => date1; set => date1 = value; }
        public DateTime Date2 { get => date2; set => date2 = value; }
        public DateTime Date3 { get => date3; set => date3 = value; }
        public DateTime Date4 { get => date4; set => date4 = value; }
        public DateTime Date5 { get => date5; set => date5 = value; }
        public DateTime Date6 { get => date6; set => date6 = value; }
        public DateTime Date7 { get => date7; set => date7 = value; }

        DateTime date1;
        DateTime date2;
        DateTime date3;
        DateTime date4;
        DateTime date5;
        DateTime date6;
        DateTime date7;


        


    }
}
