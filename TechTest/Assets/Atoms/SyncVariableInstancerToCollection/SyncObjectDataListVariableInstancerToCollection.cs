using UnityEngine;
using UnityAtoms.BaseAtoms;
using VRTechTest.ObjectLoading;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type ObjectDataList to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync ObjectDataList Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncObjectDataListVariableInstancerToCollection : SyncVariableInstancerToCollection<ObjectDataList, ObjectDataListVariable, ObjectDataListVariableInstancer> { }
}
