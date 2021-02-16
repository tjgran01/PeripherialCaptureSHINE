using System.Drawing;
using System.Threading;

namespace PeripherialCaptureSHINE
{
    class ScreenCaptureStream : SensorStream
    {
        const string fileEx = ".mp4";
        const int frameRate = 15;
        string _mFName;


        public void SetStreamParameters()
        {

        }
        public void CreateFile(string fPath)
        {
            this._mFName = fPath + fileEx;
        }

        public void StartStream()
        {

        }

        public void WriteToFile()
        {

        }

        public void StopStream()
        {
            
        }
    }
}
