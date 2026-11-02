using UnityEngine;

public class NativeHello : MonoBehaviour
{
    void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        using var bridge = new AndroidJavaObject("com.exercise.tracker.TrackerBridge");
        Debug.Log(bridge.Call<string>("hello"));
#endif
    }
}