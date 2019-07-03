namespace Calculator
{
    using Abstractions;

    public class EvaluationContext : IEvaluationContext
    {
       
        public EvaluationContext(int index, string token, string input)
        {
            Index = index;
            Token = token;
            Input = input;
        }

        public int Index { get; }

        public string Token { get; }

        public int Priority { get; private set; }

        public string Input { get; }

        public void SetPriority(int newPriority)
        {
            Priority = newPriority;
        }
    }
}
