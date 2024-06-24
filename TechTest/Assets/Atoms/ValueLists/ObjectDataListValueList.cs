using UnityEngine;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `ObjectDataList`. Inherits from `AtomValueList&lt;ObjectDataList, ObjectDataListEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/ObjectDataList", fileName = "ObjectDataListValueList")]
    public sealed class ObjectDataListValueList : AtomValueList<ObjectDataList, ObjectDataListEvent> { }
}
