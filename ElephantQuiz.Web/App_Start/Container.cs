using System;
using Ninject;

namespace ElephantQuiz.Web.App_Start
{
    public static class Container
    {
        private static readonly Lazy<IKernel> _kernel = new Lazy<IKernel>(() => new StandardKernel(new ContainerBindings()));

        public static IKernel Kernel
        {
            get { return _kernel.Value; }
        }
    }
}