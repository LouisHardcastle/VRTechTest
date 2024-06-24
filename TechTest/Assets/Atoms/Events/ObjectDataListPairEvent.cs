using UnityEngine;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `ObjectDataListPair`. Inherits from `AtomEvent&lt;ObjectDataListPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ObjectDataListPair", fileName = "ObjectDataListPairEvent")]
    public sealed class ObjectDataListPairEvent : AtomEvent<ObjectDataListPair>
    {
    }
}
