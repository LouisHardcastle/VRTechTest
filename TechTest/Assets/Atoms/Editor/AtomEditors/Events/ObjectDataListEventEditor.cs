#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using VRTechTest.ObjectLoading;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ObjectDataList`. Inherits from `AtomEventEditor&lt;ObjectDataList, ObjectDataListEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ObjectDataListEvent))]
    public sealed class ObjectDataListEventEditor : AtomEventEditor<ObjectDataList, ObjectDataListEvent> { }
}
#endif
