using Delta.Core;
using Delta.Model;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Persistence
{
    public static class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<Context>();

            #region Repositories

            container.RegisterType<IRepository<Product>, ProductRepository>();

            #endregion
        }
    }
}
