using GourmetGame.WindowsFormsApp.Forms;

namespace GourmetGame.WindowsFormsApp
{
    public static class InputDialog
    {
        public static string Show(string question, string dialogTitle)
        {
            var inputDialogForm = new InputDialogForm(question, dialogTitle);
            inputDialogForm.ShowDialog();
            return inputDialogForm.GetResponseText();
        }
    }
}