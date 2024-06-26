#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `ObjectDataList`. Inherits from `AtomDrawer&lt;ObjectDataListValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectDataListValueList))]
    public class ObjectDataListValueListDrawer : AtomDrawer<ObjectDataListValueList> { }
}
#endif
