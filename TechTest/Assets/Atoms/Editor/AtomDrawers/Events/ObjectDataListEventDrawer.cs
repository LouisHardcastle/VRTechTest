#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ObjectDataList`. Inherits from `AtomDrawer&lt;ObjectDataListEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectDataListEvent))]
    public class ObjectDataListEventDrawer : AtomDrawer<ObjectDataListEvent> { }
}
#endif
