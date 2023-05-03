using Lab_3.Interfaces;

namespace Lab_3;

public class NotificationSettingsHistory : INotificationSettingsHistory
{
    public Queue<INotificationSettingsMemento> History { get; }
    public NotificationSettingsHistory()
    {
        History = new Queue<INotificationSettingsMemento>();
    }
}

