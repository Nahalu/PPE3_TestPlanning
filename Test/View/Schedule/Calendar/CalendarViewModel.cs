using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Test.View.Schedule.Calendar
{
    public class CalendarViewModel : ObservableObject, IPageViewModel
    {
        private string name;
        public string Name { get => name; set => name = value; }


        public CalendarViewModel()
        {

            //if (Date1 = DateTime.Now)
            //{
            //    Date1 = "Today";
            //}else
            //{

            //}

            MondayOfTheWeek();
        }

        DateTime date1;
        DateTime date2;
        DateTime date3;
        DateTime date4;
        DateTime date5;
        DateTime date6;
        DateTime date7;

        public DateTime Date1 { get => date1; set { date1 = value; OnPropertyChanged("Date1"); } }
        public DateTime Date2 { get => date2; set { date2 = value; OnPropertyChanged("Date2"); } }
        public DateTime Date3 { get => date3; set { date3 = value; OnPropertyChanged("Date3"); } }
        public DateTime Date4 { get => date4; set { date4 = value; OnPropertyChanged("Date4"); } }
        public DateTime Date5 { get => date5; set { date5 = value; OnPropertyChanged("Date5"); } }
        public DateTime Date6 { get => date6; set { date6 = value; OnPropertyChanged("Date6"); } }
        public DateTime Date7 { get => date7; set { date7 = value; OnPropertyChanged("Date7"); } }

        public DateTime MondayOfTheWeek()
        {
            DateTime currdate = DateTime.Today;
            int delta = DayOfWeek.Monday - currdate.DayOfWeek;
            DateTime monday = currdate.AddDays(delta);

            Date1 = monday;
            Date2 = monday.AddDays(1);
            Date3 = monday.AddDays(2);
            Date4 = monday.AddDays(3);
            Date5 = monday.AddDays(4);
            Date6 = monday.AddDays(5);
            Date7 = monday.AddDays(6);

            return monday;
        }


        public void AddWeek()
        {
             Date1 = date1.AddDays(7);
             Date2 = date2.AddDays(7);
             Date3 = date3.AddDays(7);
             Date4 = date4.AddDays(7);
             Date5 = date5.AddDays(7);
             Date6 = date6.AddDays(7);
             Date7 = date7.AddDays(7);
        }

        public void RemoveWeek()
        {
            Date1 = date1.AddDays(-7);
            Date2 = date2.AddDays(-7);
            Date3 = date3.AddDays(-7);
            Date4 = date4.AddDays(-7);
            Date5 = date5.AddDays(-7);
            Date6 = date6.AddDays(-7);
            Date7 = date7.AddDays(-7);
        }


        public ICommand _NextWeek;
        public ICommand NextWeek
        {
            get
            {
                if (_NextWeek == null)
                {
                    _NextWeek = new RelayCommand(
                        p => AddWeek());
                }

                return _NextWeek;
            }

        }

        public ICommand _PreviousWeek;
        public ICommand PreviousWeek
        {
            get
            {
                if (_PreviousWeek == null)
                {
                    _PreviousWeek = new RelayCommand(
                        p => RemoveWeek());
                }

                return _PreviousWeek;
            }

        }








    }
}
