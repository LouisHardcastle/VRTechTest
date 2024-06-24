using System;
using System.Collections.Generic;
using System.IO;
using UnityAtoms;
using UnityEngine;
using Newtonsoft.Json;
using VRTechTest.Interfaces;


namespace VRTechTest.ObjectLoading
{

    public class ObjectProviderLocal : MonoBehaviour, IObjectProvider
    {

        [SerializeField]
        private string _folder;
        [SerializeField]
        private string _filename;

        private string GetFullPath() => Path.Combine(_folder, _filename);

        [SerializeField]
        private ObjectDataListVariable _objects;



        private void OnEnable()
        {
            _objects.SetValue(GetObjects());
        }



        public ObjectDataList GetObjects()
        {
            string fullPath = GetFullPath();
            if (!File.Exists(fullPath))
            {
                Debug.LogWarning("No File Exists, building json from test parameters");
            }

            LoadFromFile(fullPath, out string json);

            if (string.IsNullOrEmpty(json))
            {
                Debug.LogError("file is Empty");
                return null;
            }

            Debug.Log(json);
            ObjectDataList objects = JsonConvert.DeserializeObject<ObjectDataList>(json);

            if (objects is null)
            {
                Debug.LogError("Failed to convert json to ObjectList");
                return null;
            }

            _objects.SetValue(objects);
            return objects;
        }


        public void LoadFromFile(string fullPath,
            out string result)
        {
            try
            {
                result = File.ReadAllText(fullPath);
            }
            catch (Exception)
            {
                result = "";
            }
        }

        public void WriteToFile(string fullPath, string content)
        {
            try
            {
                File.WriteAllText(fullPath, content);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }



    }
}

