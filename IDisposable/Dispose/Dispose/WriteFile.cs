using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class WriteFile: IDisposable
    {
        private string _path;
        private StreamWriter _file;

        public WriteFile(string path)
        {
            _path = path;
            _file = new StreamWriter(path);
        }

        /* The dispose method is a method we MUST implement
         * because of the IDisposable interface */
        public void Dispose()
        {
            _file.Close();
            Console.WriteLine("Dispose executed by the using statement");
        }

        public void write(string text)
        {
            _file.WriteLine(text);
        }
    
    }
}
