using Ionic.Zip;
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
            var _SubFolders = System.IO.Directory.GetDirectories(@"D:\ComicDL\Psycho Pass Kanshikan Kougami Shinya");

            foreach (string _SubFolder in _SubFolders)
            {
                this.RenameFiles(_SubFolder);
                using (ZipFile zip = new ZipFile())
                {
                    //zip.AddDirectory(@"D:\ComicDL\Aoki Hagane No Arpeggio\Chapter 001");
                    zip.AddDirectory(_SubFolder);
                    string _OutputFullPath = @"D:\ComicDL\~Output\" + System.IO.Path.GetFileName(_SubFolder) + ".cbz";
                    zip.Save(_OutputFullPath);
                }

            }

        } //button1_Click

        private void RenameFiles(string _SubFolder)
        {

            string[] _FilePaths = Directory.GetFiles(_SubFolder);

            int _MaxFileLength = this.GetMaxNameLength(_FilePaths);

            foreach (string _InitialFilePath in _FilePaths)
            {
                string _NameWithoutExtention = System.IO.Path.GetFileNameWithoutExtension(_InitialFilePath);
                string _Extention = Path.GetExtension(_InitialFilePath);
                int _Length = _NameWithoutExtention.Length;

                if (_Length < _MaxFileLength)
                {
                    string _Destination = _SubFolder + "\\" + new string('0', _MaxFileLength - _Length) + _NameWithoutExtention + _Extention;
                    File.Move(_InitialFilePath, _Destination);
                }
            }

            //Just incase renames are still being done before zipping.
            System.Threading.Thread.Sleep(1000);

        } //RenameFiles
        
        private int GetMaxNameLength(string[] filePaths)
        {
            // Convert this to LINQ?
            int _MaxLength = 0;

            foreach (string _InitialFilePath in filePaths)
            {
                string _NameWithoutExtention = System.IO.Path.GetFileNameWithoutExtension(_InitialFilePath);
                if (_NameWithoutExtention.Length > _MaxLength)
                {
                    _MaxLength = _NameWithoutExtention.Length;
                }
            }
            return _MaxLength;
        } //GetMaxNameLength
    }
}
