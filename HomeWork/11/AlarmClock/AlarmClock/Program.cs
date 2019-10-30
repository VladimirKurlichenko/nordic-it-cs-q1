using System;

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time and message of the first alarm.");
            ReminderItem alarm1 = new ReminderItem(EnterAlarmDate(), EnterAlarmMessage());
            Console.WriteLine("Enter the time and message of the second alarm.");
            ReminderItem alarm2 = new ReminderItem(EnterAlarmDate(), EnterAlarmMessage());

            Console.WriteLine(alarm1.Description);
            Console.WriteLine(alarm2.Description);
        }

        static DateTime EnterAlarmDate()
        {
            DateTime alarmDate;
            while (true)
            {
                try
                {
                    Console.Write("Enter time: ");
                    alarmDate = DateTime.Parse(Console.ReadLine());
                    return alarmDate;
                }
                catch (FormatException formatException)
                {

                    Console.WriteLine(formatException.Message);
                }
            }
        }

        static string EnterAlarmMessage()
        {
            string alarmMessage;
            while (true)
            {
                try
                {
                    Console.Write("Enter message: ");
                    alarmMessage = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(alarmMessage))
                        throw new ArgumentNullException();

                    return alarmMessage;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                }
                catch (ArgumentNullException nullException)
                {
                    Console.WriteLine(nullException.Message);
                }
            }
        }
    }
}
