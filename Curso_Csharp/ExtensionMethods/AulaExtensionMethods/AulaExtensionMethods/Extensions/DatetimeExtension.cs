using System.Globalization;

namespace System //PODE USAR O NAMESPACE SYSTEM !!!
{
    static class DatetimeExtension
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duracao = DateTime.Now.Subtract(thisObj);
            if (duracao.TotalHours < 24.0)
            {
                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            }
            else
            {
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " dias";
            }
        }
    }
}
