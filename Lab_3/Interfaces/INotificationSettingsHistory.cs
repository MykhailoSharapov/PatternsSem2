namespace Lab_3.Interfaces
{
    public interface INotificationSettingsHistory
    {
        Queue<INotificationSettingsMemento> History { get; }
    }
}
