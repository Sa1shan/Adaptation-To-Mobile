using UnityEngine;

namespace _Source
{
    public class SafeAreaLog : MonoBehaviour
    {
        public void Start()
        {
            Log();
        }

        public void OnRectTransformDimensionsChange()
        { 
            Log();
        }
        void Log() 
        {
            Debug.Log($"[Safe Area Update] Area: {Screen.safeArea} | Resolution: {Screen.width}x{Screen.height}");
        }
    }
}
