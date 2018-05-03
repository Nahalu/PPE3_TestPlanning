﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Test.ServiceReference;

namespace Test.View.Schedule.Calendar
{
    public class CalendarViewModel : ObservableObject, IPageViewModel
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public IList<interventions> ListInterventions { get => listInterventions; set => listInterventions = value; }

        private IList<interventions> listInterventions;
        public CalendarViewModel()
        {
            MondayOfTheWeek();
            ListInterventions = new List<ServiceReference.interventions>();
            using (ServiceReference.Service1Client api = new ServiceReference.Service1Client())
            {
                listInterventions = api.GetInterventions();
            }
            
        }



        public void Today()
        {
            if (Date1 == DateTime.Today)
            {
                DateStr1 = "Today";
            }else if(Date2 == DateTime.Today)
            {
                DateStr2 = "Today";
            }else if(Date3 == DateTime.Today)
            {
                DateStr3 = "Today";
            }else if(Date4 == DateTime.Today)
            {
                DateStr4 = "Today";
            }else if(Date5 == DateTime.Today)
            {
                DateStr5 = "Today";
            }else if(Date6 == DateTime.Today)
            {
                DateStr6 = "Today";
            }else if(Date7 == DateTime.Today)
            {
                DateStr7 = "Today";
            }
        }

        DateTime date1;
        DateTime date2;
        DateTime date3;
        DateTime date4;
        DateTime date5;
        DateTime date6;
        DateTime date7;
        string datestr1;
        string datestr2;
        string datestr3;
        string datestr4;
        string datestr5;
        string datestr6;
        string datestr7;

        public DateTime Date1 { get => date1; set { date1 = value; OnPropertyChanged("Date1"); } }
        public DateTime Date2 { get => date2; set { date2 = value; OnPropertyChanged("Date2"); } }
        public DateTime Date3 { get => date3; set { date3 = value; OnPropertyChanged("Date3"); } }
        public DateTime Date4 { get => date4; set { date4 = value; OnPropertyChanged("Date4"); } }
        public DateTime Date5 { get => date5; set { date5 = value; OnPropertyChanged("Date5"); } }
        public DateTime Date6 { get => date6; set { date6 = value; OnPropertyChanged("Date6"); } }
        public DateTime Date7 { get => date7; set { date7 = value; OnPropertyChanged("Date7"); } }
        public string DateStr1 { get => datestr1; set { datestr1 = value; OnPropertyChanged("DateStr1"); } }
        public string DateStr2 { get => datestr2; set { datestr2 = value; OnPropertyChanged("DateStr2"); } }
        public string DateStr3 { get => datestr3; set { datestr3 = value; OnPropertyChanged("DateStr3"); } }
        public string DateStr4 { get => datestr4; set { datestr4 = value; OnPropertyChanged("DateStr4"); } }
        public string DateStr5 { get => datestr5; set { datestr5 = value; OnPropertyChanged("DateStr5"); } }
        public string DateStr6 { get => datestr6; set { datestr6 = value; OnPropertyChanged("DateStr6"); } }
        public string DateStr7 { get => datestr7; set { datestr7 = value; OnPropertyChanged("DateStr7"); } }

        public void MondayOfTheWeek()
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

            DateStr1 = Date1.ToString("dd/MM");
            DateStr2 = Date2.ToString("dd/MM");
            DateStr3 = Date3.ToString("dd/MM");
            DateStr4 = Date4.ToString("dd/MM");
            DateStr5 = Date5.ToString("dd/MM");
            DateStr6 = Date6.ToString("dd/MM");
            DateStr7 = Date7.ToString("dd/MM");

            Today();
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

            DateStr1 = Date1.ToString("dd/MM");
            DateStr2 = Date2.ToString("dd/MM");
            DateStr3 = Date3.ToString("dd/MM");
            DateStr4 = Date4.ToString("dd/MM");
            DateStr5 = Date5.ToString("dd/MM");
            DateStr6 = Date6.ToString("dd/MM");
            DateStr7 = Date7.ToString("dd/MM");

            Today();
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

            DateStr1 = Date1.ToString("dd/MM");
            DateStr2 = Date2.ToString("dd/MM");
            DateStr3 = Date3.ToString("dd/MM");
            DateStr4 = Date4.ToString("dd/MM");
            DateStr5 = Date5.ToString("dd/MM");
            DateStr6 = Date6.ToString("dd/MM");
            DateStr7 = Date7.ToString("dd/MM");

            Today();
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
