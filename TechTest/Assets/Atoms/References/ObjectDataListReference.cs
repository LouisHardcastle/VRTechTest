using System;
using UnityAtoms.BaseAtoms;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `ObjectDataList`. Inherits from `AtomReference&lt;ObjectDataList, ObjectDataListPair, ObjectDataListConstant, ObjectDataListVariable, ObjectDataListEvent, ObjectDataListPairEvent, ObjectDataListObjectDataListFunction, ObjectDataListVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectDataListReference : AtomReference<
        ObjectDataList,
        ObjectDataListPair,
        ObjectDataListConstant,
        ObjectDataListVariable,
        ObjectDataListEvent,
        ObjectDataListPairEvent,
        ObjectDataListObjectDataListFunction,
        ObjectDataListVariableInstancer>, IEquatable<ObjectDataListReference>
    {
        public ObjectDataListReference() : base() { }
        public ObjectDataListReference(ObjectDataList value) : base(value) { }
        public bool Equals(ObjectDataListReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ObjectDataList other)
        {
            throw new NotImplementedException();
        }
    }
}
