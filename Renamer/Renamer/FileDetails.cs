using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    class FileDetails
    {

        public FileDetails(string directory, string fileParam) {
        
            DirectoryName = directory;
            FileName = fileParam;

        }


        private string directoryName;

        public string DirectoryName
        {
            get { return directoryName; }
            set { directoryName = value; }
        }
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

    }
}
