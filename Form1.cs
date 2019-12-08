using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTxtText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dirScanner = @"the Target Path you want to search";
            //check if the Text you want to search is null
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;

            //Get all the files is .txt
            string[] allFiles = Directory.GetFiles(dirScanner, "*.txt");
            foreach (string file in allFiles)
            {
                //read each file and check if exist the target text
                string[] lines = File.ReadAllLines(file);
                foreach (string InLineText in lines)
                {
                    if (InLineText.Contains(textBox1.Text))
                    {
                        //if exist and then get the file and sidplay to listbox
                        listBox1.Items.Add(Path.GetFileName(file)); 
                    }
                } 
            }
        }
    }
}
