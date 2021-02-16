namespace PeripherialCaptureSHINE
{
    class StreamFactory
    {
        public SensorStream GetStreamOfType(string streamString)
        {
            switch (streamString)
            {
                case "SHIMMER":
                    return new ShimmerStream();
                case "Tobii":
                    return new TobiiStream();
                case "Screen Capture":
                    return new ScreenCaptureStream();
                case "Audio Capture":
                    return new AudioCaptureStream();
                default:
                    return new DefaultTextDataStream();

            };
        }
    }
}
