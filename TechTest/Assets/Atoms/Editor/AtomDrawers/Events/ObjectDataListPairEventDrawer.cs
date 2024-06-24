#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ObjectDataListPair`. Inherits from `AtomDrawer&lt;ObjectDataListPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectDataListPairEvent))]
    public class ObjectDataListPairEventDrawer : AtomDrawer<ObjectDataListPairEvent> { }
}
#endif
