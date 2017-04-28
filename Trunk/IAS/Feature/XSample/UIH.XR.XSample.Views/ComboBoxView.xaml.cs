﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIH.XR.XSample.Views
{
    /// <summary>
    /// Interaction logic for ItemsControlView.xaml
    /// </summary>
    [Export("ComboBoxView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ComboBoxView : UserControl
    {
        public ComboBoxView()
        {
            InitializeComponent();
        }
    }
}
