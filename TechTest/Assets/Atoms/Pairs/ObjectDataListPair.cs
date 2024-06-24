using System;
using UnityEngine;
using VRTechTest.ObjectLoading;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;ObjectDataList&gt;`. Inherits from `IPair&lt;ObjectDataList&gt;`.
    /// </summary>
    [Serializable]
    public struct ObjectDataListPair : IPair<ObjectDataList>
    {
        public ObjectDataList Item1 { get => _item1; set => _item1 = value; }
        public ObjectDataList Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ObjectDataList _item1;
        [SerializeField]
        private ObjectDataList _item2;

        public void Deconstruct(out ObjectDataList item1, out ObjectDataList item2) { item1 = Item1; item2 = Item2; }
    }
}