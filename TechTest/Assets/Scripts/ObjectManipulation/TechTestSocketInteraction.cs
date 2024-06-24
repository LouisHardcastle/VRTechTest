using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TechTestSocketInteraction : MonoBehaviour
{

    [SerializeField] private XRSocketInteractor _socket;
    [SerializeField] private BoolVariable _isStuck;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (_isStuck.Value) return;

        if (_socket.hasSelection)
        {
            _isStuck.SetValue(true);
        }
    }
}
