//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from "Tools\Towel_Generating\TupleExtensionsGenerator.cs".
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Towel
{
	public static partial class Statics
	{
		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<object> GetEnumerator(this System.Runtime.CompilerServices.ITuple tuple)
		{
			for (int i = 0; i < tuple.Length; i++)
			{
				yield return tuple[i];
			}
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<T> tuple)
		{
			yield return tuple.Item1;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this ValueTuple<T> tuple)
		{
			yield return tuple.Item1;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<T, T> tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this (T, T) tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T> tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this (T, T, T) tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T> tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this (T, T, T, T) tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T, T> tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
			yield return tuple.Item5;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this (T, T, T, T, T) tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
			yield return tuple.Item5;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T, T, T> tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
			yield return tuple.Item5;
			yield return tuple.Item6;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this (T, T, T, T, T, T) tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
			yield return tuple.Item5;
			yield return tuple.Item6;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T, T, T, T> tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
			yield return tuple.Item5;
			yield return tuple.Item6;
			yield return tuple.Item7;
		}

		/// <summary>Gets an enumerator for a tuple.</summary>
		/// <typeparam name="T">The type of values in the tuple.</typeparam>
		/// <param name="tuple">The tuple to get an enumerator for.</param>
		/// <returns>An enumerator for a tuple.</returns>
		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this (T, T, T, T, T, T, T) tuple)
		{
			yield return tuple.Item1;
			yield return tuple.Item2;
			yield return tuple.Item3;
			yield return tuple.Item4;
			yield return tuple.Item5;
			yield return tuple.Item6;
			yield return tuple.Item7;
		}

	}
}