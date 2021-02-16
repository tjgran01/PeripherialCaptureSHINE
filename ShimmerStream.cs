using System.IO;
using System;

namespace PeripherialCaptureSHINE
{ 
    class ShimmerStream : SensorStream
    {
        const string fileEx = ".txt";
        string _mFName;

        public void SetStreamParameters()
        {

        }
        public void CreateFile(string fName)
        {
            this._mFName = fName + fileEx;

            if (File.Exists(_mFName))
            {
                File.Delete(_mFName);
            }

            FileStream fs = File.Create(_mFName);
            fs.Close();
        }
        public void StartStream()
        {
            WriteToFile();
        }

        public void WriteToFile()
        {
            while (true)
            {
                try
                {
                    using (StreamWriter w = File.AppendText(_mFName))
                    {
                        w.WriteLine("Hello");
                        w.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }
        }

        public void StopStream()
        {

        }
    }
}
