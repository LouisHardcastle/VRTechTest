using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using VRTechTest.ObjectManipulation;

namespace VRTechTest.Managers
{
    public class InteractionManager : MonoBehaviour
    {
        private bool _hasInit;

        [SerializeField] private List<GameObject> _spawnedObjects = new();
        [SerializeField] private GameObjectEvent _objectAdded;
        [SerializeField] private GameObjectEvent _onObjectGrabbed;
        [SerializeField] private GameObjectEvent _onObjectReleased;
        [SerializeField] private GameObjectEvent _onObjectsStuck;

        [SerializeField] private VoidEvent _setup;

        [SerializeField] private int _stepsCompleted;

        private void OnEnable()
        {
            _setup?.Register(InitObjects);
            _objectAdded?.Register(AddObject);
            _onObjectGrabbed?.Register(ObjectGrabbed);
            _onObjectReleased?.Register(ObjectReleased);
            _onObjectsStuck?.Register(ObjectsStuck);
        }

        private void OnDisable()
        {
            _setup?.Unregister(InitObjects);
            _onObjectGrabbed?.Unregister(ObjectGrabbed);
            _onObjectReleased?.Unregister(ObjectReleased);
            _onObjectsStuck?.Unregister(ObjectsStuck);
        }

        private void ObjectsStuck(GameObject obj)
        {
            throw new System.NotImplementedException();
        }

        private void ObjectReleased(GameObject obj)
        {
            throw new System.NotImplementedException();
        }

    
        private void ObjectGrabbed(GameObject obj)
        {
            switch (_stepsCompleted)
            {
                case 0:
                {
                    _stepsCompleted++;
                    foreach (var spawnedObject in _spawnedObjects.Where(spawnedObject => spawnedObject.gameObject != obj))
                    {
                        spawnedObject.GetComponent<TechTestObjectInteraction>().UpdateText("Now pick me up!");
                    }

                    obj.GetComponent<TechTestObjectInteraction>().UpdateText("");


                    return;
                }

                case <= 0:
                    return;

                default:
                {
                    _stepsCompleted++;
                    foreach (var spawnedObject in _spawnedObjects)
                    {
                        spawnedObject.GetComponent<TechTestObjectInteraction>().UpdateText("Now stick us together!");
                    }

                    break;
                }
            }
        }
        

        private void AddObject(GameObject obj)
        {
            _spawnedObjects.Add(obj);
        }

        private void InitObjects(Void obj)
        {
            if (_hasInit)
                return;

            _hasInit = true;

            if (_spawnedObjects.Any(obj => _spawnedObjects[0] == null))
            {
                Debug.LogError("Spawned object does not inherit from IObject, Interactions cant resolve");
                return;
            }

            if (_stepsCompleted != 0)
                return;

            foreach (var spawnedObject in _spawnedObjects)
            {
                Debug.Log("Setting Text");
                spawnedObject.GetComponent<TechTestObjectInteraction>().UpdateText("Pick me up!");

            }
        }
    }
}
