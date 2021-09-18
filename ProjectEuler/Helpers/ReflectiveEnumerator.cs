using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ProjectEuler.Helpers
{
    /// <summary>
    /// Represents a helper class for reflective enumerators
    /// </summary>
    internal static class ReflectiveEnumerator
    {
        /// <summary>
        /// Gets all implemented classes from interface type <typeparamref name="TInterface"/> and initializes them
        /// </summary>
        /// <typeparam name="TInterface">The interface type</typeparam>
        /// <returns>An <see cref="IEnumerable{T}"/> which contains all classes which implement <typeparamref name="TInterface"/></returns>
        /// <exception cref="Exception">If <typeparamref name="TInterface"/> is not an interface</exception>
        public static IEnumerable<TInterface> GetImplementationsOfType<TInterface>()
        {
            if (!typeof(TInterface).IsInterface)
                throw new Exception($"Type parameter {nameof(TInterface)} must be an interface type");

            IList<TInterface> spottedClasses = new List<TInterface>();

            foreach (Type type in Assembly.GetAssembly(typeof(TInterface)).GetTypes()
                .Where(t => t.IsAssignableTo(typeof(TInterface))))
            {
                if (!type.IsClass)
                    continue;

                spottedClasses.Add((TInterface)Activator.CreateInstance(type));
            }

            return spottedClasses;
        }
    }
}
