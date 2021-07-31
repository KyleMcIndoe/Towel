﻿using System;

namespace Towel
{
	/// <inheritdoc cref="Lazy{T}"/>
	public struct SLazy<T>
	{
		internal class Reference
		{
			internal Func<T>? _func;
			internal T? _value;
			internal Reference(T value) => _value = value;
			internal Reference(Func<T> func) => _func = func;
		}

		internal Reference? _reference;
		internal T? _value;

		/// <summary>True if <see cref="Value"/> has been initialized.</summary>
		public bool IsValueCreated => _reference is null ? true : GetIsValueCreated();

		/// <summary>Gets the lazily initialized value.</summary>
		public T Value => _reference is null ? _value! : GetValue();

		/// <inheritdoc cref="Lazy{T}(Func{T})"/>
		public SLazy(T value)
		{
			_reference = null;
			_value = value;
		}

		/// <inheritdoc cref="Lazy{T}(Func{T})"/>
		public SLazy(Func<T> func)
		{
			if (func is null) throw new ArgumentNullException(nameof(func));
			_reference = new(func);
			_value = default;
		}

		internal bool GetIsValueCreated()
		{
			if (_reference!._func is null)
			{
				_value = _reference._value;
				_reference = null;
				return true;
			}
			return false;
		}

		internal T GetValue()
		{
			if (_reference!._func is null)
			{
				_value = _reference._value;
				_reference = null;
			}
			else
			{
				lock (_reference)
				{
					if (_reference is not null)
					{
						if (_reference._func is null)
						{
							_value = _reference._value;
						}
						else
						{
							T value = _reference._func.Invoke();
							_reference._func = default;
							_reference._value = value;
							_value = value;
						}
						_reference = null;
					}
				}
			}
			return _value!;
		}

		/// <summary>Constructs a new <see cref="SLazy{T}"/> from a <see cref="Func{T}"/>.</summary>
		/// <param name="func">The method used to initialize <see cref="Value"/>.</param>
		public static implicit operator SLazy<T>(Func<T> func) => new(func);

		/// <summary>Constructs a new <see cref="SLazy{T}"/> from a <typeparamref name="T"/>.</summary>
		/// <param name="value">The value to initialize <see cref="Value"/> with.</param>
		public static implicit operator SLazy<T>(T value) => new(value);

		/// <summary>Checks for equality between <see cref="Value"/> and <paramref name="obj"/>.</summary>
		/// <param name="obj">The value to compare to <see cref="Value"/>.</param>
		/// <returns>True if <see cref="Value"/> and <paramref name="obj"/> are equal or False if not.</returns>
		public override bool Equals(object? obj)
		{
			if (obj is SLazy<T> slazy)
			{
				obj = slazy.Value;
			}
			return (Value, obj) switch
			{
				(null, null) => true,
				(_,    null) => false,
				(null,    _) => false,
				_ => Value!.Equals(obj),
			};
		}

		/// <summary>Returns a string that represents <see cref="Value"/>.</summary>
		/// <returns>A string that represents <see cref="Value"/></returns>
		public override string? ToString() => Value?.ToString();

		/// <summary>Gets the hash code of <see cref="Value"/>.</summary>
		/// <returns>The hash code of <see cref="Value"/>.</returns>
		public override int GetHashCode() => Value?.GetHashCode() ?? default;
	}
}
