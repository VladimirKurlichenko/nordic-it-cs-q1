using System;

namespace AlarmClockV_0._2
{
    class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }
        public ChatReminderItem(DateTime alarmDate, string alarmMessage, string chatName, string accountName) :
            base(alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
        }

        public override string Description =>
            $"Alarm date: {AlarmDate},\n" +
            $"Alarm message: {AlarmMessage},\n" +
            $"Time to alarm: {TimeToAlrm},\n" +
            $"Is out dater: {IsOutdated},\n" +
            $"Chat name: {ChatName},\n" +
            $"Account name: {AccountName}.\n";
    }
}