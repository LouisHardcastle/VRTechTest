using System;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `ObjectDataListPair`. Inherits from `AtomEventReference&lt;ObjectDataListPair, ObjectDataListVariable, ObjectDataListPairEvent, ObjectDataListVariableInstancer, ObjectDataListPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectDataListPairEventReference : AtomEventReference<
        ObjectDataListPair,
        ObjectDataListVariable,
        ObjectDataListPairEvent,
        ObjectDataListVariableInstancer,
        ObjectDataListPairEventInstancer>, IGetEvent 
    { }
}
