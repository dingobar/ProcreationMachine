using System;
namespace ProcreationMachine.Models.Exceptions
{

    public class TryingToReproduceWithSelfException : Exception
    {
        public TryingToReproduceWithSelfException()
        {
        }

        public TryingToReproduceWithSelfException(string message)
            : base(message)
        {
        }

        public TryingToReproduceWithSelfException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}