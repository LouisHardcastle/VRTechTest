using UnityEngine;
using UnityAtoms.BaseAtoms;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `ObjectDataList`. Inherits from `AtomVariableInstancer&lt;ObjectDataListVariable, ObjectDataListPair, ObjectDataList, ObjectDataListEvent, ObjectDataListPairEvent, ObjectDataListObjectDataListFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ObjectDataList Variable Instancer")]
    public class ObjectDataListVariableInstancer : AtomVariableInstancer<
        ObjectDataListVariable,
        ObjectDataListPair,
        ObjectDataList,
        ObjectDataListEvent,
        ObjectDataListPairEvent,
        ObjectDataListObjectDataListFunction>
    { }
}
