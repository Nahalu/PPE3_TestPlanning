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

namespace Test.View.Schedule.Planning
{
    /// <summary>
    /// Logique d'interaction pour PlanningView.xaml
    /// </summary>
    public partial class PlanningView : UserControl
    {

        PlanningViewModel _ViewModel = new PlanningViewModel();
        public PlanningView()
        {
            InitializeComponent();
            base.DataContext = _ViewModel;

            string test = _ViewModel.Toto;

            IList<interventions> list = _ViewModel.ListeIntervention.ToList();




            //// Ma putin de génération de datagrid
            //DataGrid monPlanning = new DataGrid();




            //DataGridTextColumn colonne1 = new DataGridTextColumn();
            //colonne1.Header = "MaBite";



            //monPlanning.Columns.Add(colonne1);

            //this.AddLogicalChild(monPlanning);
            //this.
            ColumnDefinition c1 = new ColumnDefinition();
            c1.Width = new GridLength(1, GridUnitType.Star);

            ColumnDefinition c2 = new ColumnDefinition();
            c2.Width = new GridLength(4, GridUnitType.Star);
            ColumnDefinition c3 = new ColumnDefinition();
            c3.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition c4 = new ColumnDefinition();
            c4.Width = new GridLength(3, GridUnitType.Star);

            ColumnDefinition c5 = new ColumnDefinition();
            c5.Width = new GridLength(1, GridUnitType.Star);

            Button testButton = new Button();

            testButton.Height = 30;

            testButton.Width = 50;

            testButton.Content = "Submit";

            Grid.SetColumn(testButton, 0);

            Canc.Children.Add(testButton);

            Canc.ColumnDefinitions.Add(c1);
            Canc.ColumnDefinitions.Add(c2);
            Canc.ColumnDefinitions.Add(c3);
            Canc.ColumnDefinitions.Add(c4);
            Canc.ColumnDefinitions.Add(c5);

            RowDefinition row = new RowDefinition();
            row.Height = new GridLength(1.0, GridUnitType.Star);
            RowDefinition row2 = new RowDefinition();
            row2.Height = new GridLength(1.0, GridUnitType.Star);

            Canc.RowDefinitions.Add(row);
            Canc.RowDefinitions.Add(row2);

            Border border2 = new Border();
            border2.Background = new SolidColorBrush(Colors.Purple);

            Border border1 = new Border();
            border1.Background = new SolidColorBrush(Colors.Red);

            Grid.SetColumn(border1, 0);
            Grid.SetRow(border1, 1);

            Grid.SetColumn(border2, 1);
            Grid.SetRow(border2, 0);

            Canc.Children.Add(border1);
            Canc.Children.Add(border2);


        } 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
