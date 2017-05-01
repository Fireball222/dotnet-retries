using System;
using System.Threading.Tasks;

namespace RRTools.DotNetRetries
{
    public static class Retry
    {
        public static void While<TException>(Action action, int maxAttempts, TimeSpan delay)
            where TException : Exception
        {
            while (true)
            {
                try
                {
                    action();
                    break;
                }
                catch (TException)
                {
                    Task.Delay(delay).GetAwaiter().GetResult();
                    continue;
                }
            }
        }
    }
}