using Notifications.Wpf.Core;
using System;

namespace SADT.Services.Notifications
{
    public interface INotificationService
    {
        void ShowNotification(string title = null, string message = null,
            NotificationType notificationType = NotificationType.Information, Action onClick = null, Action onClose = null);

        /// <summary>
        /// Закрывает выбранное уведомление.
        /// </summary>
        /// <param name="identifier">Уведомление, необходимое для удаления.</param>
        void CloseMessages(Guid identifier);

        /// <summary>
        /// Закрывает все открытые уведомления.
        /// </summary>
        void CloseAll();
    }
}
