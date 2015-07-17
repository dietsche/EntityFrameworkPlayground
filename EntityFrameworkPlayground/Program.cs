using System;
using EntityFrameworkPlayground.Abstract;
using EntityFrameworkPlayground.Concrete;
using Ninject;

namespace EntityFrameworkPlayground
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ioc = CreateIoCContainer();

            //This should be the *only* place in this application 
            //that we use our IoC container directly to create an object.
            var sampleQueries = ioc.Get<ISampleQueries>();

            sampleQueries.RunExample();

            Console.WriteLine();
            Console.WriteLine("Please press ENTER to exit.");
            Console.ReadLine();
        }

        private static IKernel CreateIoCContainer()
        {
            var kernel = new StandardKernel();

            //Reusable Library Bindings
            kernel.Bind<ILogger>().To<ConsoleLogger>();

            //Application Specific Bindings
            kernel.Bind<ISampleQueries>().To<SampleQueries>();

            return kernel;
        }
    }
}