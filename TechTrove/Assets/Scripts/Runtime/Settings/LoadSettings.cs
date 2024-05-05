using BayatGames.SaveGameFree;
using BayatGames.SaveGameFree.Serializers;
using UnityEngine;

public class LoadSettings : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    private void Start()
    {
        SaveGame.Encode = true;
        SaveGame.SavePath = SaveGamePath.DataPath;
        SaveGame.Serializer = new SaveGameBinarySerializer();
        if (_audio != null)
        {
            _audio.volume = SaveGame.Load<float>("SettingsVolume");
        }
    }
}
