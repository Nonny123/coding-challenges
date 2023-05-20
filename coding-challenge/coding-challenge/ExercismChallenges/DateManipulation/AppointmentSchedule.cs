using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.ExercismChallenges.DateManipulation
{
    static class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription)
        {
            DateTime result;
            DateTime.TryParseExact(appointmentDateDescription, "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result);

            return result;

        }

        public static bool HasPassed(DateTime appointmentDate)
        {
            return appointmentDate < Appointment.Schedule("7/25/2019 13:45:00") ? true : false;
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18 ? true : false;
        }

        public static string Description(DateTime appointmentDate)
        {
            string check = string.Empty;
           
            switch (appointmentDate.Hour)
            {
                case var hour when hour >= 0 && hour < 12:
                    check = "AM";
                    break;
                case var hour when hour >= 12 && hour < 24:
                    check = "PM";
                    break;
                default:
                    check = "Invalid hour";
                    break;
            }

            return $"You have an appointment on {appointmentDate.ToString("M/d/yyyy")} {appointmentDate.ToString("hh:mm:ss tt")}.";
        }

        public static DateTime AnniversaryDate()
        {
            return new DateTime(2019, 9, 15, 0, 0, 0);
        }
    }
}
