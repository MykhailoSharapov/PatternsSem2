using Lab_9.Interfaces;

namespace Lab_9;

public class SomeTubeApi : ISomeTubeApi
{
    private readonly string apiKey;

    public SomeTubeApi(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public void UploadVideo(string filePath)
    {
        Console.WriteLine($"Connect to SomeTube API by key: {apiKey}");
        Console.WriteLine($"Video {Path.GetFileName(filePath)} uploaded to SomeTube");
    }
}
