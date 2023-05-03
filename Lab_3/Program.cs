using Lab_3;
using Lab_3.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        INotificationSettingsHistory notificationSettingsHistory = new NotificationSettingsHistory();

        INotificationSettings notificationSettings = new NotificationSettings();
        notificationSettings.OnlyImportant = true;
        notificationSettingsHistory.History.Enqueue(notificationSettings.SaveState());

        PrintSettingsWithDelimiter(notificationSettings);

        notificationSettings.OnlyImportant = false;

        PrintSettingsWithDelimiter(notificationSettings);

        notificationSettings.RestoreState(notificationSettingsHistory.History.Dequeue());

        PrintSettingsWithDelimiter(notificationSettings);
    }
    private static void PrintSettingsWithDelimiter(INotificationSettings notificationSettings)
    { 
        Console.WriteLine("------------------------------------------");
        notificationSettings.ShowSettings();
    }
}
