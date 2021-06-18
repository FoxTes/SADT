using Prism.Events;

namespace SADT.Core.EventAggregator
{
    /// <summary>
    /// Второстепенный класс, предназначенный для оповещения изменения представления стартовой страницы.
    /// </summary>
    public class StartViewChangedEvent : PubSubEvent<string>
    {
    }
}
