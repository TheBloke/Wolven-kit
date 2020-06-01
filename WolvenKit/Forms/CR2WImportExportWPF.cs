using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Forms.Integration;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App.ViewModels;
using WolvenKit.WpfControlLibrary.CR2WImportExport;

namespace WolvenKit.Forms
{
    public partial class CR2WImportExportWPF : DockContent
    {
        private ElementHost ctrlHost;
        private CR2WImportExportControl wpfcontrol;
        private IViewModel viewModel;

        public CR2WImportExportWPF(IViewModel viewmodel)
        {
            viewModel = viewmodel;
            InitializeComponent();
        }

        private void CR2WImportExportWPF_Load(object sender, EventArgs e)
        {
            // WPF ELementhosting
            ctrlHost = new ElementHost
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(ctrlHost);
            wpfcontrol = new CR2WImportExportControl(viewModel);
            wpfcontrol.InitializeComponent();
            ctrlHost.Child = wpfcontrol;
            //wpfcontrol.Loaded += new RoutedEventHandler(wpfCtrl_Loaded);
        }
    }
}
