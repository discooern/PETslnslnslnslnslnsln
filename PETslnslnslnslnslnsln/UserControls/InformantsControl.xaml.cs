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
    /// Interaction logic for InformantsControl.xaml
    /// </summary>
    public partial class InformantsControl : UserControl
    {
        FunctionsLayer func;
        public InformantsControl(FunctionsLayer tmpFunc)
        {
            InitializeComponent();
            func = tmpFunc;
            DataContext = func;
        }
    }
}
