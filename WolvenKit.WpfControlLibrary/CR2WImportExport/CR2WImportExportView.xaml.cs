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
using WolvenKit.App.ViewModels;

namespace WolvenKit.WpfControlLibrary.CR2WImportExport
{
    /// <summary>
    /// Interaction logic for CR2WImportExportView.xaml
    /// </summary>
    public partial class CR2WImportExportControl : UserControl
    {
        public CR2WImportExportControl(IViewModel viewmodel)
        {
            this.DataContext = viewmodel;
        }
    }
}
