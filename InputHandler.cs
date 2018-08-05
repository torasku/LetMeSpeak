using System;

namespace LetMeSpeak
{
    public class InputHandler 
    {
        private string input;
        private string output;
        private AppSpeaker appSpeaker;
        private const string weather = "weather";
        private const string date = "date";
        private const string time = "time";

        public InputHandler()
        {
            input = null;
            output = null;
            appSpeaker = new AppSpeaker();
        }

        public string GetInput(string text)
        {
            input = text;
            if(input.Length == 0) 
            {
                return null;
            }
            return input;
        }

        public string checkInput(string text)
        {
            input = GetInput(text);
            string outputString = null;

            if (input.Contains(weather))
            {
                outputString = "The weather service is down";
            }
            else if (input.Contains(date))
            {
                outputString = "The date is" + handleDateFormat(DateTime.Today);
            }
            else if (input.Contains(time))
            {
                outputString = "The time is" + handleTimeFormat(DateTime.Now);
            }
            return outputString;
        }

        public string handleDateFormat(DateTime date)
        {
            string dateFormat = date.ToString("dd-MMMM-yy");
            return dateFormat;
        }

        public string handleTimeFormat(DateTime time)
        {
            string timeFormat = time.ToShortTimeString();
            return timeFormat;
        }

    }
}
