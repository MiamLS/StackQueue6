
namespace StackQueue6
{
    [Serializable]
    internal class MyStackIsFullException : Exception
    {
        public MyStackIsFullException(string? message) : base(message)
        {
        }

    }
}