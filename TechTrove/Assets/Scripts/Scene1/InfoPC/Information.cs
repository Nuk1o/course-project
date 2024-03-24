using UnityEngine;

public class Information : MonoBehaviour
{
    void Start()
    {
        Debug.Log($"Processor {SystemInfo.processorType}");
        Debug.Log($"Core {SystemInfo.processorCount}");
        Debug.Log($"Video Card {SystemInfo.graphicsDeviceName}");
        Debug.Log($"Device Type {SystemInfo.deviceType}");
        Debug.Log($"OS {SystemInfo.operatingSystem}");
        Debug.Log($"RAM {SystemInfo.systemMemorySize}");
    }
}
