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

namespace PETslnslnslnslnslnsln.UserControls
{
    /// <summary>
    /// Interaction logic for AgentsControl.xaml
    /// </summary>
    public partial class AgentsControl : UserControl
    {
        FunctionsLayer func;

        public AgentsControl(FunctionsLayer tmpFunc)
        {
            InitializeComponent();
            func = tmpFunc;
            DataContext = func;

            #region Handling for finding agents
            // Finds all persons that are in the agents table and puts them in a list for viewing
            List<Persons> AgentsListTMP = new List<Persons>();

            foreach(Agents agent in func.AgentsList)
            {
                foreach(Persons person in func.PersonsList)
                {
                    if(agent.PersonID == person.ID)
                    {
                        AgentsListTMP.Add(person);
                    }
                }   
            }
            #endregion
        }

        #region Data Creation Btn Events
        // Button event handlers for clicking to add/remove/update data
        private void DeleteAgent(object sender, RoutedEventArgs e)
        {
            try
            {
                func.RemoveAgent(dgAgents.SelectedItem as Agents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditAgent(object sender, RoutedEventArgs e)
        {
            try
            {
                func.UpdateAgent(dgAgents.SelectedItem as Agents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddAgent(object sender, RoutedEventArgs e)
        {
            try
            {
                func.AddAgent(dgAgents.SelectedItem as Agents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
