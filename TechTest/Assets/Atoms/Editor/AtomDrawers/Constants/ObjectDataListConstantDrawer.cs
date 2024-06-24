#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `ObjectDataList`. Inherits from `AtomDrawer&lt;ObjectDataListConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectDataListConstant))]
    public class ObjectDataListConstantDrawer : VariableDrawer<ObjectDataListConstant> { }
}
#endif
