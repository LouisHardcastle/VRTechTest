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

        [SerializeField] private AudioSource audioSource;  
        [SerializeField] private AudioClip stuckSound;

        [SerializeField] private List<GameObject> _spawnedObjects = new();
        [SerializeField] private GameObjectEvent _objectAdded;
        [SerializeField] private GameObjectEvent _onObjectGrabbed;
        [SerializeField] private VoidEvent _reset;
        [SerializeField] private VoidEvent _respawnObjects;
        [SerializeField] private VoidEvent _taskFinished;

        [SerializeField] private VoidEvent _setup;
        [SerializeField] private BoolVariable _isStuck;

        [SerializeField] private int _stepsCompleted;

        private void OnEnable()
        {
            _reset?.Register(Reset);
            _isStuck?.Changed.Register(ObjectsStuck);
            _setup?.Register(InitObjects);
            _objectAdded?.Register(AddObject);
            _onObjectGrabbed?.Register(ObjectGrabbed);
        }

        private void Reset(Void obj)
        {
            
            _isStuck.SetValue(false);
            _spawnedObjects.Clear();

            _respawnObjects?.Raise();
            _stepsCompleted = 0;
        }

        private void OnDisable()
        {
            _setup?.Unregister(InitObjects);
            _onObjectGrabbed?.Unregister(ObjectGrabbed);
            _objectAdded?.Unregister(AddObject);
            _isStuck?.Changed.Unregister(ObjectsStuck);
        }
        private void ObjectsStuck(bool isStuck)
        {
            if (!isStuck)
                return;

            _taskFinished?.Raise();

            // Play the audio cue
            if (audioSource != null && stuckSound != null)
            {
                audioSource.PlayOneShot(stuckSound);
            }

            foreach (var spawnedObject in _spawnedObjects)
            {
                spawnedObject.GetComponent<TechTestObjectInteraction>().UpdateText("");
            }
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
