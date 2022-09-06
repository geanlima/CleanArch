using System;
using System.Runtime.Serialization;

namespace CleanArch.Application.Services
{
    [Serializable]
    internal class ApplicationHandleException : Exception
    {
        public ApplicationHandleException()
        {
        }

        public ApplicationHandleException(string message) : base(message)
        {
        }

        public ApplicationHandleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApplicationHandleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}