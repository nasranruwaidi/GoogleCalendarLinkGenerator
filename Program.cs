using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Web;

namespace GoogleCalendarLinkGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = GenerateLink("Test","2020-05-20", "8:00 AM (EST)");
            Console.WriteLine(output);
            Console.WriteLine(".");
            Console.ReadLine();

        }

        static string GenerateLink(string eventName,string eventDate,string timeSlot) {
            string result = "";

            //eventDate input format = 2020-05-05
            //timeSlot input format = 10:00 AM (EST)
            //timeSlot input format = 8:00 AM (EST)

            StringBuilder sb = new StringBuilder();
            sb.Append("https://www.google.com/calendar/render?action=TEMPLATE");
            sb.Append("&text=");
            sb.Append(HttpUtility.UrlEncode(eventName));

            //Convert string to Date in UTC
            DateTime dateTime = ConvertEventDateTimeslot(eventDate, timeSlot);
            string dateTimeString = dateTime.ToString("yyyyMMdd");


            return sb.ToString();
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="eventDate"></param>
        /// <param name="timeSlot"></param>
        /// <returns></returns>
        static DateTime ConvertEventDateTimeslot(string eventDate, string timeSlot) {
            DateTime dateTime = new DateTime(2020,5,20);
            dateTime.AddHours(10);
            dateTime.AddMinutes(0);
            dateTime.AddSeconds(0);




            return dateTime;
        }
    }
}
