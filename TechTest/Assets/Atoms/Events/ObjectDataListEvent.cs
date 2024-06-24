using UnityEngine;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `ObjectDataList`. Inherits from `AtomEvent&lt;ObjectDataList&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ObjectDataList", fileName = "ObjectDataListEvent")]
    public sealed class ObjectDataListEvent : AtomEvent<ObjectDataList>
    {
    }
}
