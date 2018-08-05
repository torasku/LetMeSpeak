using System;

namespace LetMeSpeak
{
    public class InputForm : IInputForm
    {
        private string input;
        
        public InputForm()
        {
            input = null;
        }

        public void createForm()
        {
            Console.WriteLine("Write your question here: ");

            try
            {
                input = Console.ReadLine();
            }
            catch
            {
                throw new Exception("Error, could not interpret.");
            }

        }

        public string getInput()
        {
            if(input != null)
            {
                return input;
            }
            return null;
        }
        

    }
}
