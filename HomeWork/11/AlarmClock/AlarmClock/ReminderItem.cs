using System;

namespace AlarmClock
{
    class ReminderItem
    {
        public ReminderItem(DateTime alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }
        public DateTime AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlrm
        {
            get
            {
                return AlarmDate - DateTime.Now;
            }
        }
        public bool IsOutdated
        {
            get
            {
                if (TimeToAlrm >= TimeSpan.Zero)
                    return true;
                else
                    return false;
            }
        }
        public string Description =>
            $"Alarm date: {AlarmDate}, alarm message: {AlarmMessage}, time to alarm: {TimeToAlrm}, is out dater: {IsOutdated}";
    }
}
