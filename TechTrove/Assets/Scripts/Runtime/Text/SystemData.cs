using UnityEngine;

public class SystemData : MonoBehaviour
{
    [SerializeField] [TextArea] private string _text;
    [SerializeField] private TextTyperTMP _textTyperTMP;
    private void Awake()
    {
        Debug.Log($"Processor {SystemInfo.processorType}");
        Debug.Log($"Core {SystemInfo.processorCount}");
        Debug.Log($"Video Card {SystemInfo.graphicsDeviceName}");
        Debug.Log($"Device Type {SystemInfo.deviceType}");
        Debug.Log($"OS {SystemInfo.operatingSystem}");
        Debug.Log($"RAM {SystemInfo.systemMemorySize}");
    }

    private void Start()
    {
        _textTyperTMP.textToType = $"{_text} " +
                                   $"\n Тип процессора: {SystemInfo.processorType}" +
                                   $"\n Количество потоков: {SystemInfo.processorCount}" +
                                   $"\n Графическое устройство: {SystemInfo.graphicsDeviceName}" +
                                   $"\n Тип устройства: {SystemInfo.deviceType}" +
                                   $"\n Операционная система: {SystemInfo.operatingSystem}" +
                                   $"\n Оперативная память: {SystemInfo.systemMemorySize}";
        _textTyperTMP.StartTyping();
    }
}
