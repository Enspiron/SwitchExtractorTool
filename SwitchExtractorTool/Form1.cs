using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace SwitchExtractorTool
{
    public partial class Form1 : Form
    {
        CML console = new CML();

        /*
                 NSP:
        hactool.exe -t pfs0 --pfs0dir=output "file of nsp"


        XCI:
        hactool -t xci --outdir=out "place xci file"


        NCA from XCI:
        hactool -k keys.dat --section0dir=section0 --section1dir=section1 --section2dir=section2 --section3dir=section3 name.nca


        NCA of NSP:
        hactool -k keys.dat --exefsdir=exefs --romfsdir=romfs --titlekey=key nca.nca
        */

        //thanks to: https://stackoverflow.com/questions/3571627/show-hide-the-console-window-of-a-c-sharp-console-application
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        FileHandler fileHandler = new FileHandler();

        // Show
        //ShowWindow(handle, SW_SHOW);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            console.RunCommand("");
            if(!File.Exists("initialize"))
            {
                MessageBox.Show("Welcome to the Switch Game Extractor Tool! \n Some things to note: \n-It is recommended to keep the exe in the same folder as the hactool exe", "Info");
                File.Create("initialize");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "nca|*.nca|nsp|*.nsp|xci|*.xci|All|*.*";//your filter
            open.FilterIndex = 4;
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = open.FileName;//file path
                //do something...
                //file.Text = path;
            }
        }

        private void Nsp_Click(object sender, EventArgs e)
        {
            //xci convert nca
            string Converting = "Extracting NCA";
            Extract extract = new Extract(Converting);
            extract.Show();
            //console.RunCommand($"hactool -x \"{file.Text}\" --intype=pfs0 --pfs0dir=nsp_extracted");
            //nsp.Text = "Extracting Done!";
            //Task.Delay(2000);
            //nsp.Text = "Extract NSP";
        }

        private void ConvertXCI_Click(object sender, EventArgs e)
        {
            //extracting XCI
            string Converting = "Extracting XCI";
            Extract extract = new Extract(Converting);
            extract.Show();
        }

        private void Nca_Click(object sender, EventArgs e)
        {
            //eshop nca
            string Converting = "Extracting Encrypted NCA";
            Extract extract = new Extract(Converting);
            extract.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //Extract NSP
            string Converting = "Extracting NSP";
            Extract extract = new Extract(Converting);
            extract.Show();
        }
    }
}
