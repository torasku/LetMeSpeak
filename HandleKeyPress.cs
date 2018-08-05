using System;
using System.Windows.Forms;

namespace LetMeSpeak
{
    public class HandleKeyPress
    {
        public void ExitProgramOnEscPress(KeyEventArgs e, bool escPressed)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    escPressed = true;
                }
            }
            catch
            {
                throw new Exception("Error, could not identify key");
            }
           
        }
    }
}
