using System.Diagnostics;

namespace InterceptionSpike
{
    public class InterceptorDependency : IInterceptorDependency
    {
        public void DoSomethingElse()
        {
            Debug.WriteLine("Doing something else!");
        }
    }
}