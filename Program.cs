using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSpeaker appSpeaker = new AppSpeaker();
            InputHandler iHandler = new InputHandler();

            const String weather = "What is the weather";
            const String date = "What is the date";
            const String time = "What is the time";

            List<String> inputs = new List<string>();
            inputs.Add(weather);
            inputs.Add(date);
            inputs.Add(time);

            appSpeaker.SpeakByText("Welcome to AppSpeaker");

            foreach (String element in inputs)
            {
                appSpeaker.SpeakByText(iHandler.checkInput(iHandler.GetInput(element)));
            }

            appSpeaker.SpeakByText("Goodbye");


        }
    }
}
