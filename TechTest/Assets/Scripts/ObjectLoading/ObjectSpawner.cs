using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using VRTechTest.ObjectLoading;
using ObjectData = VRTechTest.ObjectLoading.ObjectData;

namespace VRTechTest.ObjectManipulation
{
    public class ObjectSpawner : MonoBehaviour
    {

        [SerializeField] private ObjectDataListVariable _objects;
        [SerializeField] private VoidEvent _spawnObjects;
        [SerializeField] private List<GameObject> _spawnedObjects = new();
        [SerializeField] private GameObjectEvent _objectSpawned;
        [SerializeField] private VoidEvent _setup;

        private void OnEnable()
        {
            _objects?.Changed.Register(ObjectListUpdated);
        }

        private void OnDisable()
        {
            _objects?.Changed.Unregister(ObjectListUpdated);
        }

        private void ObjectListUpdated(ObjectDataList obj)
        {
            foreach (ObjectData objectData in obj.Objects)
            {
                if (Resources.Load<GameObject>(objectData.ResourceName) is null)
                {
                    Debug.LogError("No matching Resource found");
                    return;
                }

                GameObject newObject = Instantiate(Resources.Load<GameObject>(objectData.ResourceName));
               
                Color objectColour = GetColour(objectData.Colour);
                Renderer renderer = newObject.GetComponentInChildren<MeshRenderer>();
                Material newMat = new Material(renderer.material);
                newMat.color = GetColour(objectData.Colour);
                renderer.sharedMaterial = newMat;

                newObject.transform.position = GetSpawnLocation(objectData.SpawnPosition);
                newObject.transform.eulerAngles = new Vector3(0, 90, 0);

                _spawnedObjects.Add(newObject);
            }

            AddGameObjectsToManager();
            _setup?.Raise();
        }

        private void AddGameObjectsToManager()
        {
            foreach (GameObject obj in _spawnedObjects)
            {
                _objectSpawned?.Raise(obj);
            }
        }

        private Vector3 GetSpawnLocation(float[] objectDataPosition)
        {
            return new Vector3(objectDataPosition[0], objectDataPosition[1], objectDataPosition[2]);
        }

        private Color GetColour(int[] objectDataColour)
        {
            return new Color(objectDataColour[0], objectDataColour[1], objectDataColour[2]);

        }
    }
}
