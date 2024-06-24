
namespace VRTechTest.ObjectLoading
{
    [System.Serializable]
    public class ObjectData
    {
        public float[] SpawnPosition;
        public int[] Colour;
        public bool isInteractable;

        //todo: stretch goal for demo, use Addressables instead of Resources.Load
        public string ResourceName;

    }
}