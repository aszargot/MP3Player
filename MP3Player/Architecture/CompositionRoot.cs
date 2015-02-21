using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player.Architecture
{
    public class CompositionRoot
    {
        private static IKernel _kernel;

        static CompositionRoot()
        {
            _kernel = new StandardKernel();
        }

        public static void Wire(INinjectModule module)
        {
            _kernel.Load(module);
        }

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }
    }
}
