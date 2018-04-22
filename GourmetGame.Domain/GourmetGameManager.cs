using GourmetGame.CrossCutting.Resources;

namespace GourmetGame.Domain
{
    public abstract class GourmetGameManager
    {
        public GameNode Root { get; private set; }

        public GourmetGameManager()
        {
            Root = new GameNode(GameMessages.Pasta,
                 new GameNode(GameMessages.Lasagna),
                 new GameNode(GameMessages.ChocolateCake));
        }

        public void StartGame()
        {
            AskQuestions(Root);
        }

        private void AskQuestions(GameNode currentNode)
        {
            var saidYes = MakeQuestion(string.Format(GameMessages.TheDishIs, currentNode.Description), GameMessages.Confirm);

            if (saidYes)
            {
                if (currentNode.LeftNode == null)
                    ShowGameOverMessage(GameMessages.IGotItRightAgain);
                else
                    AskQuestions(currentNode.LeftNode);
            }
            else
            {
                if (currentNode.RightNode == null)
                    InsertNewFood(currentNode);
                else
                    AskQuestions(currentNode.RightNode);
            }
        }

        private void InsertNewFood(GameNode currentNode)
        {
            var currentFood = currentNode.Description;
            var correctFood = MakeQuestionWithTextInput(GameMessages.WhatDishDidYouThink, GameMessages.GiveUp);
            var question = string.Format(GameMessages.ThisDishIsButTheOtherIsNot, correctFood, currentFood);
            var comparisonQuestion = MakeQuestionWithTextInput(question, GameMessages.Answer);

            currentNode.UpdateNodeDescription(comparisonQuestion);
            currentNode.SetLeftNode(new GameNode(correctFood));
            currentNode.SetRightNode(new GameNode(currentFood));
        }

        public abstract bool MakeQuestion(string question, string dialogTitle);

        public abstract string MakeQuestionWithTextInput(string question, string dialogTitle);

        public abstract void ShowGameOverMessage(string message);
    }
}