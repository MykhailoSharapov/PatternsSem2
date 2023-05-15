using Lab_9;
using Lab_9.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IVideoUploaderFacade uploader = new VideoUploaderFacade("0711CD9A-02E9-4358-ACE9-D778BA9CA6D7");

        uploader.UploadVideo(@"C:\SomeFolder\SomeVideo.avi");
    }
}
