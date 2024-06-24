using TMPro;
using Unity.VisualScripting;
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
        [SerializeField] private VoidEvent _reset;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _grabbedObject = GetComponent<XRGrabInteractable>();
        }

        private void OnEnable()
        {
            _grabbedObject.selectEntered.AddListener(OnObjectGrabbed);
        }

        public void UpdateText(string text)
        {
            _textMesh.SetText(text);
        }

        private Vector3 _offsetPosition;
        private Quaternion _offsetRotation;


        private void OnDisable()
        {
            _grabbedObject.selectEntered.RemoveListener(OnObjectGrabbed);
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
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer != 6)
                return;

            _reset?.Raise();
            
        }

    }
}