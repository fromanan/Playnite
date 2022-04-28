﻿using Playnite.Controls;
using Playnite.Windows;
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
using System.Windows.Shapes;

namespace Playnite.FullscreenApp.Windows
{
    public class HelpMenuWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new HelpMenuWindow();
        }
    }

    /// <summary>
    /// Interaction logic for HelpMenuWindowMenuWindow.xaml
    /// </summary>
    public partial class HelpMenuWindow : WindowBase
    {
        public HelpMenuWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
