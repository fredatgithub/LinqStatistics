﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
        /// <summary>
        /// Returns all non-null items in a sequence
        /// </summary>
        /// <typeparam name="T">The type of the sequence</typeparam>
        /// <param name="source">The Sequence</param>
        /// <returns>All non-null elements in the sequence</returns>
        public static IEnumerable<T> AllValues<T>(this IEnumerable<T?> source) where T : struct
        {
            if (source == null)
                throw new ArgumentNullException("source", "The source enumeration cannot be null");

            return source.Where(x => x.HasValue).Select(x => (T)x);
        }

        /// <summary>
        /// Returns all elements in a sequence of Tuples where the Tuple's are not null
        /// </summary>
        /// <typeparam name="T">The type of the Tuple's Items</typeparam>
        /// <param name="source">The sequence</param>
        /// <returns>All Tuples in the sequence with non-null items</returns>
        public static IEnumerable<Tuple<T, T>> AllValues<T>(this IEnumerable<Tuple<T?, T?>> source) where T : struct
        {
            if (source == null)
                throw new ArgumentNullException("source", "The source enumeration cannot be null");

            return source.Where(x => x.Item1.HasValue && x.Item2.HasValue).Select(t => new Tuple<T, T>((T)t.Item1, (T)t.Item2));
        }
    }
}
