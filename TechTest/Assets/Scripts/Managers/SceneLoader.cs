using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRTechTest.Managers
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private List<string> _additiveScenes;

        private void OnEnable()
        {
            foreach (string scene in _additiveScenes)
            {
                SceneManager.LoadScene(scene, LoadSceneMode.Additive);
            }
        }


    }
}
