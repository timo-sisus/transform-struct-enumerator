using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Sisus
{
	/// <summary>
	/// Extensions methods for the <see cref="Transform"/> component.
	/// </summary>
	public static class TransformExtensions
	{
		/// <summary>
		/// Gets a enumerator that can be used to iterate the immediate children of the <paramref name="transform"/>
		/// using a foreach loop, without any garbage being generated from the operation.
	    /// </summary>
		/// <example>
		/// <code>
		/// foreach(Transform child in transform.GetChildren())
		/// {
		///		Debug.Log(child.name, child);
		/// }
		/// </code>
		/// </example>
		/// <param name="transform"> The <see cref="Transform"/> component whose children to iterate. </param>
		/// <returns> A struct-based enumerator. </returns>
		public static Children GetChildren([DisallowNull] this Transform transform) => new(transform);
	}
}
