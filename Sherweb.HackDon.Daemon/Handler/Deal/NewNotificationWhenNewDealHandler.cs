using System;
using Gorilla.Startup.OneSignal;
using Moment.Services.Models;

namespace Moment.Services.Daemon.Handler.Deal
{
    public class NewNotificationWhenNewDealHandler
    {
        private readonly IOneSignalNotificationService _notificationService;
        private readonly MomentContext _momentContext;

        public NewNotificationWhenNewDealHandler(IOneSignalNotificationService notificationService, MomentContext momentContext)
        {
            this._notificationService = notificationService;
            this._momentContext = momentContext;
        }

        public void Handle(Models.Entities.Deal deal)
        {
            var businessName = _momentContext.Businesses.Find(deal.BusinessId)?.Name;
            var result = _notificationService.SendNotification("Nouvelle offre disponible!", $"De nouvelles offres sont disponibles chez {businessName}!", deal.StartDate);

            var dealNotification = _momentContext.Deals.Find(deal.Id);
            if (dealNotification != null) dealNotification.NotificationId = new Guid(result.Id);
            _momentContext.SaveChanges();

            Console.WriteLine($"Nouvelle notification({result.Id}) créé avec succès! De nouvelles offres sont disponibles chez {businessName}!");
        }
    }
}