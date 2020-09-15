﻿using System;

namespace Towel
{
	/// <summary>Interface for a compile time delegate.</summary>
	public interface IAction
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		void Do();
	}

	/// <summary>Built in struct for runtime computations.</summary>
	public struct ActionRuntime : IAction
	{
		internal Action Action;

		/// <summary>The invocation of the compile time delegate.</summary>
		public void Do() => Action();

		/// <summary>Implicitly wraps runtime computation inside a compile time struct.</summary>
		/// <param name="action">The runtime delegate.</param>
		public static implicit operator ActionRuntime(Action action) => new ActionRuntime() { Action = action, };
	}

	/// <summary>Interface for a compile time delegate.</summary>
	public interface IAction<A>
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		void Do(A a);
	}

	/// <summary>Interface for a compile time delegate.</summary>
	public interface IAction<A, B>
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		void Do(A a, B b);
	}

	/// <summary>Interface for a compile time delegate.</summary>
	public interface IAction<A, B, C>
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		void Do(A a, B b, C c);
	}

	/// <summary>Interface for a compile time delegate.</summary>
	public interface IFunc<A>
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		A Do();
	}

	/// <summary>Built in struct for runtime computations.</summary>
	public struct FuncRuntime<A> : IFunc<A>
	{
		internal Func<A> Func;

		/// <summary>The invocation of the compile time delegate.</summary>
		public A Do() => Func();

		/// <summary>Implicitly wraps runtime computation inside a compile time struct.</summary>
		/// <param name="func">The runtime delegate.</param>
		public static implicit operator FuncRuntime<A>(Func<A> func) => new FuncRuntime<A>() { Func = func, };
	}

	/// <summary>Interface for a compile time delegate.</summary>
	public interface IFunc<A, B>
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		B Do(A a);
	}

	/// <summary>Built in struct for runtime computations.</summary>
	public struct FuncRuntime<A, B> : IFunc<A, B>
	{
		internal Func<A, B> _func;
		/// <summary>The invocation of the compile time delegate.</summary>
		public B Do(A a) => _func(a);
		/// <summary>Implicitly wraps runtime computation inside a compile time struct.</summary>
		/// <param name="func">The runtime delegate.</param>
		public static implicit operator FuncRuntime<A, B>(Func<A, B> func) => new FuncRuntime<A, B>() { _func = func, };
	}

	/// <summary>Interface for a compile time delegate.</summary>
	public interface IFunc<A, B, C>
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		C Do(A a, B b);
	}

	/// <summary>Built in struct for runtime computations.</summary>
	public struct FuncRuntime<A, B, C> : IFunc<A, B, C>
	{
		internal Func<A, B, C> _func;

		/// <summary>The invocation of the compile time delegate.</summary>
		public C Do(A a, B b) => _func(a, b);

		/// <summary>Implicitly wraps runtime computation inside a compile time struct.</summary>
		/// <param name="func">The runtime delegate.</param>
		public static implicit operator FuncRuntime<A, B, C>(Func<A, B, C> func) => new FuncRuntime<A, B, C>() { _func = func, };
	}

	/// <summary>Interface for a compile time delegate.</summary>
	public interface IFunc<A, B, C, D>
	{
		/// <summary>The invocation of the compile time delegate.</summary>
		D Do(A a, B b, C c);
	}
}
