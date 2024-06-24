using UnityEditor;
using UnityAtoms.Editor;
using VRTechTest.ObjectLoading;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `ObjectDataList`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ObjectDataListVariable))]
    public sealed class ObjectDataListVariableEditor : AtomVariableEditor<ObjectDataList, ObjectDataListPair> { }
}
