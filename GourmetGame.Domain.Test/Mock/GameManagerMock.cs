using System;

namespace GourmetGame.Domain.Test.Mock
{
    internal class GameManagerMock : GourmetGameManager
    {
        public override bool MakeQuestion(string question, string dialogTitle)
        {
            return !string.IsNullOrEmpty(question);
        }

        public override string MakeQuestionWithTextInput(string question, string dialogTitle)
        {
            return question;
        }

        public override void ShowGameOverMessage(string message)
        {
            throw new Exception(message);
        }
    }
}