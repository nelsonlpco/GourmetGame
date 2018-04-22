using GourmetGame.CrossCutting.Resources;
using GourmetGame.Domain;
using System.Windows.Forms;

namespace GourmetGame.WindowsFormsApp
{
    public class GameManager : GourmetGameManager
    {
        public override bool MakeQuestion(string question, string dialogTitle)
        {
            var response = MessageBox.Show(question, dialogTitle, MessageBoxButtons.YesNo);
            return response == DialogResult.Yes;
        }

        public override string MakeQuestionWithTextInput(string question, string dialogTitle)
        {
            return InputDialog.Show(question, dialogTitle);
        }

        public override void ShowGameOverMessage(string message)
        {
            MessageBox.Show(message, GameMessages.GameTitle, MessageBoxButtons.OK);
        }
    }
}