using Delta.Core;
using Delta.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Persistence
{
    public static class Extensions
    {
        /// <summary>
        /// Determines if an element with the provided exists inside a collection
        /// </summary>
        /// <typeparam name="T">Collection type</typeparam>
        /// <param name="collection">Collection</param>
        /// <param name="id">Id of the element to be search</param>
        /// <returns></returns>
        public static bool Exists<T>(this DbSet<T> collection, long id) where T : Entity
        {
            return collection.Count(e => e.Id == id) > 0;
        }
    }
}
