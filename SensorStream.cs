using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeripherialCaptureSHINE
{
    interface SensorStream
    {
        void SetStreamParameters();
        void CreateFile(string fPath);
        void StartStream();
        void WriteToFile();
        void StopStream();
    }
}
