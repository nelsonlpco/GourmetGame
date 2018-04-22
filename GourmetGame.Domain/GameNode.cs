namespace GourmetGame.Domain
{
    public sealed class GameNode
    {
        public GameNode(string description)
        {
            Description = description;
        }

        public GameNode(string description, GameNode leftNode, GameNode rightNode)
            : this(description)
        {
            LeftNode = leftNode;
            RightNode = rightNode;
        }

        public GameNode LeftNode { get; private set; }
        public GameNode RightNode { get; private set; }
        public string Description { get; private set; }

        public void UpdateNodeDescription(string description)
        {
            Description = description;
        }

        public void SetLeftNode(GameNode leftNode)
        {
            LeftNode = leftNode;
        }

        public void SetRightNode(GameNode rightNode)
        {
            RightNode = rightNode;
        }
    }
}