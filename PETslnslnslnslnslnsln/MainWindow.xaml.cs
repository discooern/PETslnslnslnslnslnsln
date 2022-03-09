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
using System.Windows.Media.Animation;

namespace PETslnslnslnslnslnsln
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FunctionsLayer func = new FunctionsLayer();

        #region UserControls Properties
        public UserControls.AgentsControl UCAgents;
        public UserControls.InformantsControl UCInformants;
        public UserControls.LogsControl UCLogs;
        public UserControls.ObservantGroupsControl UCObservantGroups;
        public UserControls.ObservantsControl UCObservants;
        public UserControls.ObservationsControl UCObservations;
        public UserControls.PersonsControl UCPersons;
        public UserControl userControl;
        #endregion

        private Storyboard myStoryboardEnter;
        private Storyboard myStoryboardLeave;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = func;

            #region Animation Enter
            // Properties for setting the enter animation
            var myDoubleAnimationEnter = new DoubleAnimation();
            // Properties for setting the leave animation
            myDoubleAnimationEnter.From = 1.0;
            myDoubleAnimationEnter.To = 0.0;
            // Animation duration
            myDoubleAnimationEnter.Duration = new Duration(TimeSpan.FromSeconds(.5));
            myStoryboardEnter = new Storyboard();
            myStoryboardEnter.Children.Add(myDoubleAnimationEnter);
            myStoryboardEnter.Completed += new EventHandler(myStoryboardEnter_Completed);
            // Sets the property to change when doing animation
            Storyboard.SetTargetName(myDoubleAnimationEnter, GridRight.Name);
            Storyboard.SetTargetProperty(myDoubleAnimationEnter, new PropertyPath(Grid.OpacityProperty));
            #endregion
            #region Animation Leave
            // Properties for setting the leave animation
            var myDoubleAnimationLeave = new DoubleAnimation();
            // Animation start and end values
            myDoubleAnimationLeave.From = 0.0;
            myDoubleAnimationLeave.To = 1.0;
            // Animation duration
            myDoubleAnimationLeave.Duration = new Duration(TimeSpan.FromSeconds(.5));
            myStoryboardLeave = new Storyboard();
            myStoryboardLeave.Children.Add(myDoubleAnimationLeave);
            // Sets the property to change when doing animation
            Storyboard.SetTargetName(myDoubleAnimationLeave, GridRight.Name);
            Storyboard.SetTargetProperty(myDoubleAnimationLeave, new PropertyPath(Grid.OpacityProperty));
            #endregion

            #region UserControl Init
            UCAgents = new UserControls.AgentsControl(func);
            UCInformants = new UserControls.InformantsControl(func);
            UCLogs = new UserControls.LogsControl(func);
            UCObservantGroups = new UserControls.ObservantGroupsControl(func);
            UCObservants = new UserControls.ObservantsControl(func);
            UCObservations = new UserControls.ObservationsControl(func);
            UCPersons = new UserControls.PersonsControl(func);
            #endregion
        }

        // When animationEnter has finished runs this code to set new userControl then starts the animationLeave
        private void myStoryboardEnter_Completed(object sender, EventArgs e)
        {
            GridRight.Children.Clear();
            GridRight.Children.Add(userControl);
            myStoryboardLeave.Begin(this);
        }

        // If user clicks button to show user control disable corresponding button
        private void btnEnabled(Button tmp)
        {
            btnAgents.IsEnabled = true;
            btnInformants.IsEnabled = true;
            btnObservants.IsEnabled = true;
            btnObservantGroups.IsEnabled = true;
            btnPersons.IsEnabled = true;
            btnObservations.IsEnabled = true;
            btnLogs.IsEnabled = true;

            tmp.IsEnabled = false;
        }

        #region UserControls interaction
        /// <summary>
        // Sets the displayed userControl to "UserControl" starts an animation and disables the corresponding button
        /// </summary>
        private void btnAgents_click(object sender, RoutedEventArgs e)
        {
            userControl = UCAgents;
            myStoryboardEnter.Begin(this);
            btnEnabled(btnAgents);
        }

        private void btnInformants_Click(object sender, RoutedEventArgs e)
        {
            userControl = UCInformants;
            myStoryboardEnter.Begin(this);
            btnEnabled(btnInformants);
        }

        private void btnObservants_Click(object sender, RoutedEventArgs e)
        {
            userControl = UCObservants;
            myStoryboardEnter.Begin(this);
            btnEnabled(btnObservants);
        }

        private void btnObservantGroups_Click(object sender, RoutedEventArgs e)
        {
            userControl = UCObservantGroups;
            myStoryboardEnter.Begin(this);
            btnEnabled(btnObservantGroups);
        }

        private void btnPersons_Click(object sender, RoutedEventArgs e)
        {
            userControl = UCPersons;
            myStoryboardEnter.Begin(this);
            btnEnabled(btnPersons);
        }

        private void btnObservations_Click(object sender, RoutedEventArgs e)
        {
            userControl = UCObservations;
            myStoryboardEnter.Begin(this);
            btnEnabled(btnObservations);
        }

        private void btnLogs_Click(object sender, RoutedEventArgs e)
        {
            userControl = UCLogs;
            myStoryboardEnter.Begin(this);
            btnEnabled(btnLogs);
        }
        #endregion
    }
}
