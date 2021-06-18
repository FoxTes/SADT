using Prism.Events;

namespace SADT.Core.EventAggregator
{
    /// <summary>
    /// Второстепенный класс, предназначенный для оповещения закрытия стартовой страницы.
    /// </summary>
    public class StartViewClosedEvent : PubSubEvent<bool>
    {
    }
}
