using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Test.ServiceReference;

namespace Test.View.Schedule.Planning
{
    public class PlanningViewModel : ObservableObject, IPageViewModel
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public string Toto { get => toto; set => toto = value; }
        public IList<interventions> ListeIntervention { get => listeIntervention; set => listeIntervention = value; }

        string toto;

        IList<ServiceReference.interventions> listeIntervention;
      public PlanningViewModel()
      {
            toto = "test";
            ListeIntervention = new List<ServiceReference.interventions>();

            using (ServiceReference.Service1Client api = new ServiceReference.Service1Client())
            {
                DateTime start = DateTime.Now.AddYears(-2);
                DateTime end = DateTime.Now.AddYears(2);
                listeIntervention=api.GetPlanning(start, end);
            }


  
            

            //var grid = this. as Grid;


            /*
             *  <DataGrid ItemsSource="{Binding MyData}" SelectedItem="{Binding SelectedCustomer}" Grid.Row="3" Margin="0,5,0,0" IsSynchronizedWithCurrentItem="True" AutoGenerateColumns="False">

            <DataGrid.Columns>
                <DataGridTextColumn Header="ID" Binding="{Binding id}"/>
                <DataGridTextColumn Header="Nom" Binding="{Binding lastname}"/>
                <DataGridTextColumn Header="Prénom" Binding="{Binding firstname}"/>
                <DataGridTextColumn Header="Email" Binding="{Binding email}"/>
                <DataGridTextColumn Header="Phone" Binding="{Binding phone}"/>
                <DataGridTextColumn Header="Mobile" Binding="{Binding mobile}"/>
                <DataGridTextColumn Header="Date de Naissance" Binding="{Binding birthdate}"/>
                <DataGridComboBoxColumn Header="Rôle" ItemsSource="{Binding ListRoles}">
                </DataGridComboBoxColumn>
                <DataGridTextColumn Header="Actif" Binding="{Binding isActive}"/>

            </DataGrid.Columns>
            </DataGrid>
             *
             * 
             * 
             * 
             * 
             * private void calculate()
            {
                decimal sum1 = 0;

                foreach (GridViewRow i in this.gv1.Rows)
                {

                    decimal e = Convert.ToDecimal(i.Cells[5].Text.ToString());
                    sum1 = sum1 + e;
                }

                txtSubTotal.Text = sum1.ToString();

            }
             */
        }

    }
}
