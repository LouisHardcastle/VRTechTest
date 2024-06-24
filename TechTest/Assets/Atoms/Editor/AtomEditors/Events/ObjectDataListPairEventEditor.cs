#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using VRTechTest.ObjectLoading;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ObjectDataListPair`. Inherits from `AtomEventEditor&lt;ObjectDataListPair, ObjectDataListPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ObjectDataListPairEvent))]
    public sealed class ObjectDataListPairEventEditor : AtomEventEditor<ObjectDataListPair, ObjectDataListPairEvent> { }
}
#endif
