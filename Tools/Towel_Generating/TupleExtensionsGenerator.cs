﻿using System.IO;
using System.Text;

namespace Towel_Generating;

public static class TupleExtensionsGenerator
{
	public static string Run(int size = Program.DefaultGenerationCount)
	{
		string generatorPath = Path.GetRelativePath(Path.Combine(Path.GetDirectoryName(sourcefilepath())!, "..", ".."), sourcefilepath());

		StringBuilder code = new();
		code.AppendLine($@"//------------------------------------------------------------------------------");
		code.AppendLine($@"// <auto-generated>");
		code.AppendLine($@"// This code was generated from ""{generatorPath}"".");
		code.AppendLine($@"// </auto-generated>");
		code.AppendLine($@"//------------------------------------------------------------------------------");
		code.AppendLine($@"");
		code.AppendLine($@"using System;");
		code.AppendLine($@"");
		code.AppendLine($@"namespace Towel");
		code.AppendLine($@"{{");
		code.AppendLine($@"	public static partial class Statics");
		code.AppendLine($@"	{{");
		code.AppendLine($@"		/// <summary>Gets an enumerator for a tuple.</summary>");
		code.AppendLine($@"		/// <param name=""tuple"">The tuple to get an enumerator for.</param>");
		code.AppendLine($@"		/// <returns>An enumerator for a tuple.</returns>");
		code.AppendLine($@"		public static System.Collections.Generic.IEnumerator<object> GetEnumerator(this System.Runtime.CompilerServices.ITuple tuple)");
		code.AppendLine($@"		{{");
		code.AppendLine($@"			for (int i = 0; i < tuple.Length; i++)");
		code.AppendLine($@"			{{");
		code.AppendLine($@"				yield return tuple[i];");
		code.AppendLine($@"			}}");
		code.AppendLine($@"		}}");
		code.AppendLine($@"");
		for (int i = 1, I = 2; i <= size; i++, I++)
		{
			code.AppendLine($@"		/// <summary>Gets an enumerator for a tuple.</summary>");
			code.AppendLine($@"		/// <typeparam name=""T"">The type of values in the tuple.</typeparam>");
			code.AppendLine($@"		/// <param name=""tuple"">The tuple to get an enumerator for.</param>");
			code.AppendLine($@"		/// <returns>An enumerator for a tuple.</returns>");
			code.AppendLine($@"		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this Tuple<{Join(1..I, n => $"T", ", ")}> tuple)");
			code.AppendLine($@"		{{");
			for (int j = 1; j <= i; j++)
			{
				code.AppendLine($@"			yield return tuple.Item{j};");
			}
			code.AppendLine($@"		}}");
			code.AppendLine($@"");
			code.AppendLine($@"		/// <summary>Gets an enumerator for a tuple.</summary>");
			code.AppendLine($@"		/// <typeparam name=""T"">The type of values in the tuple.</typeparam>");
			code.AppendLine($@"		/// <param name=""tuple"">The tuple to get an enumerator for.</param>");
			code.AppendLine($@"		/// <returns>An enumerator for a tuple.</returns>");
			code.AppendLine($@"		public static System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(this {(i is 1 ? "ValueTuple<T>" : $"({Join(1..I, n => $"T", ", ")})")} tuple)");
			code.AppendLine($@"		{{");
			for (int j = 1; j <= i; j++)
			{
				code.AppendLine($@"			yield return tuple.Item{j};");
			}
			code.AppendLine($@"		}}");
			code.AppendLine($@"");
		}
		code.AppendLine($@"	}}");
		code.AppendLine($@"}}");
		return code.ToString();
	}
}
