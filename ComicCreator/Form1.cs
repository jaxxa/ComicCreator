using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Iterate through Source
            //System.IO.DirectoryInfo = BN
            var _SubFolders = System.IO.Directory.GetDirectories(@"D:\ComicDL\~Source\Aoki Hagane No Arpeggio");

            foreach (string _SubFolder in _SubFolders)
            {

                using (ZipFile zip = new ZipFile())
                {
                    //zip.AddDirectory(@"D:\ComicDL\Aoki Hagane No Arpeggio\Chapter 001");
                    zip.AddDirectory(_SubFolder);
                    string _OutputFullPath = @"D:\ComicDL\~Output\" + System.IO.Path.GetFileName(_SubFolder) + ".cbz";
                    zip.Save(_OutputFullPath);
                }

            }

        }
    }
}
