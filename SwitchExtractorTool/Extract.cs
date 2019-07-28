using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SwitchExtractorTool
{
    public partial class Extract : Form
    {
        CML console = new CML();
        FileHandler fileHandler = new FileHandler();

        private string converting;

        public Extract()
        {
            InitializeComponent();
        }

        public Extract(string converting)
        {
            InitializeComponent();

            this.converting = converting;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = converting;
            if(label1.Text == "Extracting Encrypted NCA")
            {
                label2.Show();
                tkey.Show();
            }else
            {
                label2.Hide();
                tkey.Hide();
            }
            if(!File.Exists("keys.dat") || !File.Exists("hactool.exe"))
            {
                MessageBox.Show("I can't extract anything without hactool.exe or a keys.dat!\n\n Opening directory of exe");
                System.Diagnostics.Process.Start(fileHandler.GetExecutingDirectoryName());

                this.Close();
            }
            ExtractB.Text = "Set Paths";
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FileName.Text = fileHandler.OpenFile();
        }

        private void ExtractB_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Extracting NCA")
            {
                //Extracts an nca from xci or xci convert (unencrypted)
                console.RunCommand($"hactool -k keys.dat --section0dir={Out.Text}\\section0 --section1dir={Out.Text}\\section1 --section2dir={Out.Text}\\section2 --section3dir={Out.Text}\\section3 {FileName.Text}");
                if (ExtractB.Text == "Extract!")
                {
                    MessageBox.Show("NCA Extracted!");
                    System.Diagnostics.Process.Start(Out.Text);
                }
                ExtractB.Text = "Extract!";

            }
            if (label1.Text == "Extracting XCI")
            {
                //Extract XCI
                console.RunCommand($"hactool -t xci --outdir=\"{Out.Text}\" \"{FileName.Text}\"");

                if (ExtractB.Text == "Extract!")
                {
                    //console.RunCommand($"hactool -t xci --outdir=\"{Out.Text}\" \"{FileName.Text}\"");
                    MessageBox.Show("XCI Extracted!");
                    System.Diagnostics.Process.Start(Out.Text);
                }
                ExtractB.Text = "Extract!";

            }
            if (label1.Text == "Extracting Encrypted NCA")
            {
                //If NCA is from a non-xci convert, then use this               

                console.RunCommand($"hactool -k keys.dat --exefsdir={Out.Text}\\exefs --romfsdir={Out.Text}\\romfs --titlekey={tkey.Text} {FileName.Text}");
                if (tkey.Text.Contains(" "))
                {
                    tkey.Text = tkey.Text.Replace(" ", "");
                }
                if (ExtractB.Text == "Extract!") 
                {                  
                    MessageBox.Show("NCA Extracted!");
                    System.Diagnostics.Process.Start(Out.Text);
                }
                    ExtractB.Text = "Extract!";
            }
            if (label1.Text == "Extracting NSP")
            {
                //Extract an NSP
                console.RunCommand($"hactool.exe -t pfs0 --pfs0dir={Out.Text} \"{FileName.Text}\"");
                if(ExtractB.Text == "Extract!")
                {
                    MessageBox.Show("NSP Extracted!");
                    System.Diagnostics.Process.Start(Out.Text);
                }
                ExtractB.Text = "Extract!";

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Out.Text = fileHandler.OpenPath();
        }
    }
}
