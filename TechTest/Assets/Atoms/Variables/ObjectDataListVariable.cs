using UnityEngine;
using System;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `ObjectDataList`. Inherits from `AtomVariable&lt;ObjectDataList, ObjectDataListPair, ObjectDataListEvent, ObjectDataListPairEvent, ObjectDataListObjectDataListFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ObjectDataList", fileName = "ObjectDataListVariable")]
    public sealed class ObjectDataListVariable : AtomVariable<ObjectDataList, ObjectDataListPair, ObjectDataListEvent, ObjectDataListPairEvent, ObjectDataListObjectDataListFunction>
    {
        protected override bool ValueEquals(ObjectDataList other)
        {
            return this.Value.Equals(other);
        }
    }
}
