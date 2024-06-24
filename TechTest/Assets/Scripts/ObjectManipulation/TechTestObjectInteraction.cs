using TMPro;
using Unity.XR.CoreUtils;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

namespace VRTechTest.ObjectManipulation
{
    public class TechTestObjectInteraction : XRBaseGrabTransformer
    {
        private XRGrabInteractable _grabbedObject;
        private Rigidbody _rigidBody;

        [SerializeField] private TextMeshProUGUI _textMesh;

        [SerializeField] private bool _isStuck;
        [SerializeField] private GameObjectEvent _objectGrabbed;
        [SerializeField] private GameObjectEvent _objectReleased;
        [SerializeField] private GameObjectEvent _objectStuck;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _grabbedObject = GetComponent<XRGrabInteractable>();
        }

        private void OnEnable()
        {
            _grabbedObject.selectEntered.AddListener(OnObjectGrabbed);
            _grabbedObject.selectExited.AddListener(OnObjectReleased);
        }

        public void UpdateText(string text)
        {
            _textMesh.SetText(text);
        }

        private Vector3 _offsetPosition;
        private Quaternion _offsetRotation;

        private void OnObjectReleased(SelectExitEventArgs evt)
        {
            _objectReleased?.Raise(gameObject);
        }

        private void OnDisable()
        {
            _grabbedObject.selectEntered.RemoveListener(OnObjectGrabbed);
            _grabbedObject.selectExited.RemoveListener(OnObjectReleased);
        }

        private void OnObjectGrabbed(SelectEnterEventArgs evt)
        {
            _rigidBody.constraints = RigidbodyConstraints.None;
            _objectGrabbed?.Raise(gameObject);
        }

        public override void Process(XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale)
        {
            Pose interactorPose = grabInteractable.interactorsSelecting[0].GetAttachTransform(grabInteractable).GetWorldPose();
            targetPose.position = interactorPose.position + _offsetPosition;
            targetPose.rotation = interactorPose.rotation * _offsetRotation;
        }

    }
}