using System;
using System.Speech.Synthesis;

namespace LetMeSpeak
{
    public class Speaker : ISpeaker
    {
        private SpeechSynthesizer speaker;

        public Speaker()
        {
            speaker = new SpeechSynthesizer();
        }

        public void SpeakByText(string text)
        {
            speaker.Speak(text);
        }


    }
}
