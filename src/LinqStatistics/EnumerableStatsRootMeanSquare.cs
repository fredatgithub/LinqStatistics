﻿//
// THIS FILE IS AUTOGENERATED - DO NOT EDIT
// In order to make changes make sure to edit the t4 template file (*.tt)
//

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
    	
        /// <summary>
        ///     The RootMeanSquare of the sequence of nullable int values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double? RootMeanSquare(this IEnumerable<int?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.RootMeanSquare();

            return null;
        }

        /// <summary>
        ///     The RootMeanSquare of the sequence of int values.
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double RootMeanSquare(this IEnumerable<int> source)
        {
            ArgumentNullException.ThrowIfNull(source);

            var s = 0.0;
            long n = 0;

            checked
            { 
                foreach (var d in source)
                {
                    n++;
                    s += Math.Pow((double)d, 2);
                }
            }

            if (n < 1)
                throw new InvalidOperationException("source sequence contains no elements");

            return (double)Math.Sqrt(s / n);
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of nullable int values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double? RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of int values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }
 	
        /// <summary>
        ///     The RootMeanSquare of the sequence of nullable long values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </summary>
        /// <param name="source">A sequence of long values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double? RootMeanSquare(this IEnumerable<long?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.RootMeanSquare();

            return null;
        }

        /// <summary>
        ///     The RootMeanSquare of the sequence of long values.
        /// </summary>
        /// <param name="source">A sequence of long values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double RootMeanSquare(this IEnumerable<long> source)
        {
            ArgumentNullException.ThrowIfNull(source);

            var s = 0.0;
            long n = 0;

            checked
            { 
                foreach (var d in source)
                {
                    n++;
                    s += Math.Pow((double)d, 2);
                }
            }

            if (n < 1)
                throw new InvalidOperationException("source sequence contains no elements");

            return (double)Math.Sqrt(s / n);
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of nullable long values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double? RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of long values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }
 	
        /// <summary>
        ///     The RootMeanSquare of the sequence of nullable decimal values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </summary>
        /// <param name="source">A sequence of decimal values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static decimal? RootMeanSquare(this IEnumerable<decimal?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.RootMeanSquare();

            return null;
        }

        /// <summary>
        ///     The RootMeanSquare of the sequence of decimal values.
        /// </summary>
        /// <param name="source">A sequence of decimal values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static decimal RootMeanSquare(this IEnumerable<decimal> source)
        {
            ArgumentNullException.ThrowIfNull(source);

            var s = 0.0;
            long n = 0;

            checked
            { 
                foreach (var d in source)
                {
                    n++;
                    s += Math.Pow((double)d, 2);
                }
            }

            if (n < 1)
                throw new InvalidOperationException("source sequence contains no elements");

            return (decimal)Math.Sqrt(s / n);
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of nullable decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static decimal? RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static decimal RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }
 	
        /// <summary>
        ///     The RootMeanSquare of the sequence of nullable float values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </summary>
        /// <param name="source">A sequence of float values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static float? RootMeanSquare(this IEnumerable<float?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.RootMeanSquare();

            return null;
        }

        /// <summary>
        ///     The RootMeanSquare of the sequence of float values.
        /// </summary>
        /// <param name="source">A sequence of float values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static float RootMeanSquare(this IEnumerable<float> source)
        {
            ArgumentNullException.ThrowIfNull(source);

            var s = 0.0;
            long n = 0;

            checked
            { 
                foreach (var d in source)
                {
                    n++;
                    s += Math.Pow((double)d, 2);
                }
            }

            if (n < 1)
                throw new InvalidOperationException("source sequence contains no elements");

            return (float)Math.Sqrt(s / n);
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of nullable float values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static float? RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of float values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static float RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }
 	
        /// <summary>
        ///     The RootMeanSquare of the sequence of nullable double values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double? RootMeanSquare(this IEnumerable<double?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.RootMeanSquare();

            return null;
        }

        /// <summary>
        ///     The RootMeanSquare of the sequence of double values.
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the RootMeanSquare of.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double RootMeanSquare(this IEnumerable<double> source)
        {
            ArgumentNullException.ThrowIfNull(source);

            var s = 0.0;
            long n = 0;

            checked
            { 
                foreach (var d in source)
                {
                    n++;
                    s += Math.Pow((double)d, 2);
                }
            }

            if (n < 1)
                throw new InvalidOperationException("source sequence contains no elements");

            return (double)Math.Sqrt(s / n);
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of nullable double values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double? RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }

        /// <summary>
        /// Computes the RootMeanSquare of a sequence of double values that are obtained
        /// by invoking a transform function on each element of the input sequence.        
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the RootMeanSquare of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The RootMeanSquare.</returns>
        /// <remarks>![equation](~/images/rms.gif)</remarks>
        public static double RootMeanSquare<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).RootMeanSquare();
        }
     }
}