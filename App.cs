using System.Windows.Forms;

namespace LetMeSpeak
{
    public class App
    {
        private AppSpeaker appSpeaker;
        private InputHandler iHandler;
        private InputForm iForm;
        private HandleKeyPress handleKeyPress;
        private KeyEventArgs e;
        private string input;

        public void init()
        {
            appSpeaker = new AppSpeaker();
            iHandler = new InputHandler();
            iForm = new InputForm();
            handleKeyPress = new HandleKeyPress();
 
        }

        public void run()
        {
            bool escPressed = false;
            int count = 0;

            appSpeaker.SpeakByText("Welcome to AppSpeaker");
            appSpeaker.SpeakByText("Ask me about something");

            while (!escPressed)
            {
                //handleKeyPress.ExitProgramOnEscPress(e, escPressed); //TODO: handle Exception in HandleKeyPress
                if(count > 0)
                {
                    appSpeaker.SpeakByText("Ask me a new question please");
                }
                iForm.createForm();
                input = iForm.getInput();

                appSpeaker.SpeakByText(iHandler.checkInput(input));
                count++;
            }

            appSpeaker.SpeakByText("Goodbye");
        }
    }
}
