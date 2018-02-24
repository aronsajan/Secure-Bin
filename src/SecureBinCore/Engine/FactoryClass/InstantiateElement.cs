#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SecureBinCore.Engine.FactoryClass
{
    public class InstantiateElement
    {
        #region Instantiating Function
        public object CreateNewInstance(string assemblyName, params object[] arguments)
        {
            object newObj = Activator.CreateInstance(Type.GetType(assemblyName), arguments);
            return (newObj);
        }
        #endregion

    }
}

#endregion