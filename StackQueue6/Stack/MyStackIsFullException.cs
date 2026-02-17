namespace StackQueue6.Stack
{
    [Serializable]
    internal class MyStackIsFullException : Exception
    {
        public MyStackIsFullException(string? message) : base(message)
        {
        }

    }
}