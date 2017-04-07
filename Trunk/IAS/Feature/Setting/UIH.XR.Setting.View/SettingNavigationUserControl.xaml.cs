﻿using System;
using System.Collections.Generic;
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
using System.ComponentModel.Composition;
using UIH.XR.Core;
using UIH.XR.Common.MVVM;
using UIH.XR.GlobalParameter;

namespace UIH.XR.Setting.View
{
    /// <summary>
    /// Interaction logic for SettingNavigationUserControl.xaml
    /// </summary>
    [Export(ComponentContract.Setting.ViewName, typeof(UserControl))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SettingNavigationUserControl : UserControl
    {
        #region Properties

        /// <summary>
        /// Logger
        /// </summary>
        public ILogger Logger { get; set; }

        #endregion


        #region Constructor

        [ImportingConstructor]
        public SettingNavigationUserControl([Import(ComponentContract.Setting.ViewModelName, typeof(NotificationObject))]NotificationObject viewModel, [Import(typeof(ILogger))]ILogger logger)
        {
            Logger = logger;
            Logger.LoggerName = ComponentContract.Setting.LogSource;

            InitializeComponent();
            this.DataContext = viewModel;

        }


        #endregion

    }
}
