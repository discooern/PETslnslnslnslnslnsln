﻿using System;
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
    /// Interaction logic for ObservantGroupsControl.xaml
    /// </summary>
    public partial class ObservantGroupsControl : UserControl
    {
        FunctionsLayer func;
        public ObservantGroupsControl(FunctionsLayer tmpFunc)
        {
            InitializeComponent();
            func = tmpFunc;
            DataContext = func;
        }
    }
}
