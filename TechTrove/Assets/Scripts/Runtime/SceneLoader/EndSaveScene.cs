using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSaveScene : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Awake()
    {
        _button.onClick.AddListener(delegate { CloseScene(); });
    }

    private void CloseScene()
    {
        string filePath = Application.dataPath + "/systemdata.txt";
        string systemData = $"\n Тип процессора: {SystemInfo.processorType}" +
                            $"\n Количество потоков: {SystemInfo.processorCount}" +
                            $"\n Графическое устройство: {SystemInfo.graphicsDeviceName}" +
                            $"\n Тип устройства: {SystemInfo.deviceType}" +
                            $"\n Операционная система: {SystemInfo.operatingSystem}" +
                            $"\n Оперативная память: {SystemInfo.systemMemorySize}";;
        File.WriteAllText(filePath, systemData);

        Debug.Log("System data saved to: " + filePath);
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
