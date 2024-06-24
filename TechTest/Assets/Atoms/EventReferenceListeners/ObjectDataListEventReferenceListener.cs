using UnityEngine;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ObjectDataList`. Inherits from `AtomEventReferenceListener&lt;ObjectDataList, ObjectDataListEvent, ObjectDataListEventReference, ObjectDataListUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ObjectDataList Event Reference Listener")]
    public sealed class ObjectDataListEventReferenceListener : AtomEventReferenceListener<
        ObjectDataList,
        ObjectDataListEvent,
        ObjectDataListEventReference,
        ObjectDataListUnityEvent>
    { }
}
