using UnityEngine;

namespace Sisus
{
    /// <summary>
    /// Struct-based enumerator for the <see cref="Transform"/> component.
    /// <para>
    /// Enables iterating the immedite children of a transform using a foreach loop
    /// without any garbage being generated from the operation.
    /// </para>
    /// </summary>
    public struct Children
    {
        private readonly Transform transform;
        private readonly int childCount;
        private int currentIndex;

        public Children(Transform transform)
        {
            this.transform = transform;
            currentIndex = -1;

            #if DEBUG || SAFE_MODE
            if(transform == null)
			{
                Debug.LogError($"Attempted to iterate over the children of a game object that is null.", transform);
                childCount = 0;
                return;
			}
            #endif

		    childCount = transform.childCount;
        }

        public bool MoveNext() => ++currentIndex < childCount;

        public Transform Current
        {
            get
            {
                #if DEBUG || SAFE_MODE
                if(transform == null)
			    {
                    Debug.LogError($"Game object was destroyed while its children were being iterated.", transform);
                    return null;
			    }
                #endif

                return transform.GetChild(currentIndex);
            }
        }

        public Children GetEnumerator() => this;
    }
}
