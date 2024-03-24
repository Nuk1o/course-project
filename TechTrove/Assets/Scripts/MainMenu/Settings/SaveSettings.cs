using BayatGames.SaveGameFree;
using BayatGames.SaveGameFree.Serializers;
using UnityEngine;
using UnityEngine.UI;

public class SaveSettings : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        SaveGame.Encode = true;
        SaveGame.SavePath = SaveGamePath.DataPath;
        SaveGame.Serializer = new SaveGameBinarySerializer();
        _slider.value = SaveGame.Load<float>("SettingsVolume");
    }

    public void SaveData()
    {
        SaveGame.Encode = true;
        SaveGame.SavePath = SaveGamePath.DataPath;
        SaveGame.Serializer = new SaveGameBinarySerializer();
        SaveGame.Save("SettingsVolume",_slider.value);
        Debug.Log(SaveGame.SavePath);
    }

    public void LoadData()
    {
        Debug.Log(SaveGame.Load<float>("SettingsVolume"));
    }
}
