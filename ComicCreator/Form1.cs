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
            var _SubFolders = System.IO.Directory.GetDirectories(@"D:\ComicDL\~Source\Aoki Hagane No Arpeggio");

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

        }

        private void RenameFiles(string _SubFolder)
        {

            var _FilePaths = Directory.GetFiles(_SubFolder);
            foreach (string _InitialFilePath in _FilePaths)
            {
                var _NameWithoutExtention = System.IO.Path.GetFileNameWithoutExtension(_InitialFilePath);
                
                string _Destination;
                switch (_NameWithoutExtention)
                {
                    case "1":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);
                        break;
                    case "2":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                    case "3":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                    case "4":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                    case "5":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                    case "6":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                    case "7":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                    case "8":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                    case "9":
                        _Destination = _SubFolder + "\\0" + _NameWithoutExtention + ".jpg";
                        File.Move(_InitialFilePath, _Destination);

                        break;
                }

                //System.IO.File.Move(oldNameFullPath, newNameFullPath);

            }

            System.Threading.Thread.Sleep(1000);

        }
    }
}
