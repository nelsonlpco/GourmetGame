using GourmetGame.CrossCutting.Resources;
using System.Windows.Forms;

namespace GourmetGame.WindowsFormsApp.Forms
{
    public partial class GourmetGameForm : Form
    {
        private GameManager gameManager;

        public GourmetGameForm()
        {
            InitializeComponent();
            Text = GameMessages.GameTitle;
            LbInitialMessage.Text = GameMessages.ThinkOfADishYouLike;
            btnStartGame.Click += (sender, e) => gameManager.StartGame();
            gameManager = new GameManager();
        }
    }
}