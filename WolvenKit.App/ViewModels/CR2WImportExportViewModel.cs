using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WolvenKit.App.Commands;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace WolvenKit.App.ViewModels
{
    public class CR2WImportExportViewModel : ViewModel
    {
        private string _sourcePath;
        public string SourcePath
        {
            get => _sourcePath;
            set => _sourcePath = value;
        }

        private string _output;
        public string Output
        {
            get => _output;
            set => _output = value;
        }

        private string _runButtonText = "Run";
        public string RunButtonText
        {
            get => _runButtonText;
            set => _runButtonText = value;
        }

        private bool _outputSingleFile = false;
        public bool OutputSingleFile
        {
            get => _outputSingleFile;
            set => _outputSingleFile = value;
        }

        public bool RadOutputSingle
        {
            get => OutputSingleFile;
            set => OutputSingleFile = value;
        }
        public bool RadOutputSeparate
        {
            get => !OutputSingleFile; 
            set => OutputSingleFile = !value;
        }

        public ICommand SetSourcePath { get; }
        public CR2WImportExportViewModel()
        {
            SetSourcePath = new RelayCommand(SetSource, CanSetSource);
            //SetSourcePath = new DelegateCommand(SetSource, CanSetSource);
        }

        public bool CanSetSource() => true;
        protected void SetSource()
        {
            Console.WriteLine("SetSource activated");
            var dlg = new FolderBrowserDialog
            {
                Description = "Choose path containing unbundled CR2W files."
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SourcePath = dlg.SelectedPath;
            }
        }

    }
}
