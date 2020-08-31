using System;
namespace Bayolu.SharedKernel
{
    public class BayoluException : Exception
    {
        public BayoluException(string message) : base(message)
        {
        }
    }
}
