using Abp.Notifications;
using MeiLian.Dto;

namespace MeiLian.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}
