using GourmetGame.CrossCutting.Resources;
using System.Windows.Forms;

namespace GourmetGame.WindowsFormsApp.Forms
{
    public partial class InputDialogForm : Form
    {
        public InputDialogForm(string question, string dialogTitle)
        {
            InitializeComponent();
            lbQuestion.Text = question;
            Text = dialogTitle;
            btnConfirm.Text = GameMessages.Confirm;
            btnConfirm.Click += (sender, e) => Close();
            txtResponse.Select();
        }

        public string GetResponseText() => txtResponse.Text;
    }
}