using CommandPattern.Exe2.Interfaces;

namespace CommandPattern.Exe2
{
    public class State : IState
    {
        public State(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

    }
}
