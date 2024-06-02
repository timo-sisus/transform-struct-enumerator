#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

namespace Sisus
{
	public static class Test
	{
		[MenuItem("Test/Test Non-Allocating Transform Enumerator")]
		public static void TestNonAllocatingTransformEnumerator()
		{
			if(Selection.activeTransform is not Transform transform || transform == null)
			{
				Debug.Log("No game object selected in the scene hierarchy.");
				return;
			}

			int counter = 0;

			long usedMemoryBefore = Profiler.GetMonoUsedSizeLong();
			foreach(var child in transform.GetChildren())
			{
				counter++;
			}
			long usedMemoryAfter = Profiler.GetMonoUsedSizeLong();

			if(usedMemoryAfter > usedMemoryBefore)
			{
				Debug.LogError($"Allocated memory increased from {usedMemoryBefore} to {usedMemoryAfter}.", transform);
			}
			else
			{
				Debug.Log($"Iterated {counter} children of {transform.name} without generating any garbage.", transform);
			}
		}
	}
}
#endif
