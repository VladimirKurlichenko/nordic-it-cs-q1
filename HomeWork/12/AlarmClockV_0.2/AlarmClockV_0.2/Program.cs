using System;
using System.Collections.Generic;

namespace AlarmClockV_0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var reminders = new List<ReminderItem>();

            Console.WriteLine("Enter the time and message of the first alarm.");
            var alarm_1 = new ReminderItem(EnterAlarmDate(), EnterTypeString("Enter message: "));
            Console.WriteLine("\nEnter the time and message of the second alarm.");
            var alarm_2 = new PhoneReminderItem(EnterAlarmDate(), EnterTypeString("Enter message: "), EnterTypeString("Enter phone number: "));
            Console.WriteLine("\nEnter the time and message of the third alarm.");
            var alarm_3 = new ChatReminderItem(EnterAlarmDate(), EnterTypeString("Enter message: "),
                EnterTypeString("Enter chat name: "), EnterTypeString("Enter account name: "));

            reminders.Add(alarm_1);
            reminders.Add(alarm_2);
            reminders.Add(alarm_3);

            foreach (var reminder in reminders)
            {
                Console.WriteLine($"\nType: {reminder.GetType()}");
                Console.WriteLine(reminder.Description);
            }
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

        static string EnterTypeString(string message)
        {
            string alarmMessage;
            while (true)
            {
                try
                {
                    Console.Write(message);
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