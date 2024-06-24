using UnityEngine;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ObjectDataListPair`. Inherits from `AtomEventReferenceListener&lt;ObjectDataListPair, ObjectDataListPairEvent, ObjectDataListPairEventReference, ObjectDataListPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ObjectDataListPair Event Reference Listener")]
    public sealed class ObjectDataListPairEventReferenceListener : AtomEventReferenceListener<
        ObjectDataListPair,
        ObjectDataListPairEvent,
        ObjectDataListPairEventReference,
        ObjectDataListPairUnityEvent>
    { }
}
