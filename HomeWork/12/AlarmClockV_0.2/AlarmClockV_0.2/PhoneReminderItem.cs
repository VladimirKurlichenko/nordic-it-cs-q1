using System;

namespace AlarmClockV_0._2
{
    class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }
        public PhoneReminderItem(DateTime alarmDate, string alarmMessage, string phoneNumber) :
            base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
        }
        public override string Description =>
            $"Alarm date: {AlarmDate},\n" +
            $"Alarm message: {AlarmMessage},\n" +
            $"Time to alarm: {TimeToAlrm},\n" +
            $"Is out dater: {IsOutdated},\n" +
            $"Phone number: {PhoneNumber}.\n";

    }
}