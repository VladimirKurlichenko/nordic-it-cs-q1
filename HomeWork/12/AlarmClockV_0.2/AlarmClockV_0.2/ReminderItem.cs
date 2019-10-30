using System;

namespace AlarmClockV_0._2
{
    class ReminderItem
    {
        public DateTime AlarmDate { get; set; }
        public string AlarmMessage { get; set; }

        public ReminderItem(DateTime alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

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

        public virtual string Description =>
            $"Alarm date: {AlarmDate},\n" +
            $"Alarm message: {AlarmMessage},\n" +
            $"Time to alarm: {TimeToAlrm},\n" +
            $"Is out dater: {IsOutdated}.\n";
    }
}