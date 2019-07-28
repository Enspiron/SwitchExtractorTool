using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SwitchExtractorTool
{
    class FileHandler
    {
        public string OpenFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "nca|*.nca|nsp|*.nsp|xci|*.xci|All|*.*";//your filter
            open.FilterIndex = 4;
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                return open.FileName;//file path                
            }else
            {
                return null;
            }
        }

        public string OpenPath()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
