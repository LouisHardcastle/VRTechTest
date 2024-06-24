using UnityEngine;
using UnityAtoms.BaseAtoms;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `ObjectDataList`. Inherits from `SetVariableValue&lt;ObjectDataList, ObjectDataListPair, ObjectDataListVariable, ObjectDataListConstant, ObjectDataListReference, ObjectDataListEvent, ObjectDataListPairEvent, ObjectDataListVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ObjectDataList", fileName = "SetObjectDataListVariableValue")]
    public sealed class SetObjectDataListVariableValue : SetVariableValue<
        ObjectDataList,
        ObjectDataListPair,
        ObjectDataListVariable,
        ObjectDataListConstant,
        ObjectDataListReference,
        ObjectDataListEvent,
        ObjectDataListPairEvent,
        ObjectDataListObjectDataListFunction,
        ObjectDataListVariableInstancer>
    { }
}
