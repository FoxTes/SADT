using Notifications.Wpf.Core;
using Notifications.Wpf.Core.Controls;
using System;

namespace SADT.Services.Notifications
{
    public class NotificationService : INotificationService
    {
        private readonly NotificationManager _notificationManager;

        public NotificationService()
        {
            _notificationManager = new NotificationManager(NotificationPosition.BottomRight);
        }

        public async void ShowNotification(string title = null, string message = null, 
            NotificationType notificationType = NotificationType.Information, Action onClick = null, Action onClose = null)
        {
            await _notificationManager.ShowAsync(new NotificationContent
            {
                Title = title,
                Message = message,
                Type = notificationType
            },
            areaName: "MainWindowArea",
            onClick: () => onClick?.Invoke(), 
            onClose: () => onClose?.Invoke());
        }

        public async void CloseMessages(Guid identifier)
        {
            await _notificationManager.CloseAsync(identifier);
        }

        public void CloseAll()
        {
            _notificationManager.CloseAllAsync();
        }
    }
}
