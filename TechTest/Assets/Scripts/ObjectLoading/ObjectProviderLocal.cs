using System;
using System.IO;
using Newtonsoft.Json;
using UnityAtoms;
using UnityEditor.Rendering;
using UnityEngine;
using VRTechTest.Interfaces;

namespace VRTechTest.ObjectLoading
{
    public class ObjectProviderLocal : MonoBehaviour, IObjectProvider
    {

        [SerializeField] private string _folder;
        [SerializeField] private string _filename;
        [SerializeField] private ObjectDataListVariable _objects;

        private string GetFullPath() => Path.Combine(_folder, _filename);

        private void OnEnable()
        {
            _objects?.SetValue(GetObjects());
        }

        public ObjectDataList GetObjects()
        {
            string path = GetFullPath();
            if (!File.Exists(path))
            {
                Debug.LogWarning("No file exists, building local json for testing");
                WriteToFile(path, CreateJson());
            }

            LoadFromFile(path, out string json);

            if (string.IsNullOrEmpty(json))
            {
                Debug.LogError("File is empty");
                return null;
            }

            ObjectDataList objects = JsonConvert.DeserializeObject<ObjectDataList>(json);
            _objects.SetValue(objects);

            return objects;
        }

        private void WriteToFile(string path, string createJson)
        {
            try
            {
                File.WriteAllText(path, createJson);
            }
            catch (Exception)
            {
                Debug.LogError("Failed to write json");
            }
        }

        private string CreateJson()
        {
            ObjectDataList objectsToWrite = new()
            {
                Objects = new()
                {
                    new()
                    {
                        SpawnPosition = new float[] { 0, 0, 0 },
                        Colour = new[] { 255, 0, 0 },
                        isInteractable = true,
                        ResourceName = "Cube"
                    },
                    new()
                    {
                        SpawnPosition = new float[] { 0, 0, 0 },
                        Colour = new[] { 255, 0, 0 },
                        isInteractable = true,
                        ResourceName = "CubeSocket"
                    }
                }
            };

            return JsonConvert.SerializeObject(objectsToWrite);
        }

        private void LoadFromFile(string path, out string result)
        {
            try
            {
                result = File.ReadAllText(path);
            }
            catch (Exception)
            {
                Debug.LogError("Failed to read from file");
                result = "";
            }
        }
    }
}
