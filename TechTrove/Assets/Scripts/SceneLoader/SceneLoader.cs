using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Image _imageBG;
    [SerializeField] private string _nextSceneName;
    [SerializeField] private GameObject _progressBar;
    [SerializeField] private Slider _progressBarSlider;
    [SerializeField] private TMP_Text _loadingText;
    [SerializeField] private GameObject _pressKey;

    private AsyncOperation _asyncOperation;

    public void IntermediateSceneLoad()
    {
        StartCoroutine(AsyncLoadPressKeyCOR(_nextSceneName));
    }


    IEnumerator AsyncLoadPressKeyCOR(string sceneName)
    {
        _imageBG.enabled = true;
        
        float loadingProgress;
        _asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        _progressBar.SetActive(true);
        _loadingText.gameObject.SetActive(true);
        _asyncOperation.allowSceneActivation = false;
        while (_asyncOperation.progress < 0.9f)
        {
            loadingProgress = Mathf.Clamp01(_asyncOperation.progress / 0.9f);
            _loadingText.text = $"Загрузка ... {(loadingProgress*100).ToString("0")}%";
            _progressBarSlider.value = loadingProgress;
            yield return true;
        }
        _loadingText.text = $"Загрузка ... {100.ToString("0")}%";
        _progressBar.SetActive(false);
        _pressKey.SetActive(true);
    }

    private void Update()
    {
        if (_pressKey.activeInHierarchy)
        {
            if (Input.anyKey)
            {
                _asyncOperation.allowSceneActivation = true;
            }
        }
    }
}
