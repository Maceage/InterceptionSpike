using System.Diagnostics;
using Castle.DynamicProxy;

namespace InterceptionSpike
{
    public class ServiceInterceptor : IInterceptor
    {
        private readonly IInterceptorDependency _interceptorDependency;

        public ServiceInterceptor(IInterceptorDependency interceptorDependency)
        {
            _interceptorDependency = interceptorDependency;
        }
        
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("Interceptor called!");

            _interceptorDependency.DoSomethingElse();

            invocation.Proceed();
        }
    }
}