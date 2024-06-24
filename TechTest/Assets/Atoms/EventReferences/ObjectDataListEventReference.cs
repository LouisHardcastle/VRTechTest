using System;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `ObjectDataList`. Inherits from `AtomEventReference&lt;ObjectDataList, ObjectDataListVariable, ObjectDataListEvent, ObjectDataListVariableInstancer, ObjectDataListEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectDataListEventReference : AtomEventReference<
        ObjectDataList,
        ObjectDataListVariable,
        ObjectDataListEvent,
        ObjectDataListVariableInstancer,
        ObjectDataListEventInstancer>, IGetEvent 
    { }
}
