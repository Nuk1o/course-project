using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

[RequireComponent (typeof (TextMeshProUGUI))]
public class TextTyperTMP : MonoBehaviour 
{	
	[Header("Settings")]
	[SerializeField] private float _typeSpeed = 0.1f;
	[SerializeField] private float _startDelay = 0.5f;
	[SerializeField] private float _volumeVariation = 0.1f;
	[SerializeField] private bool _startOnStart = false;

	[Header("Components")]
	[SerializeField] private AudioSource _mainAudioSource;

	[SerializeField] private TMP_Text _textComponent;

	private bool _typing;
	private int _counter;
	private string _textToType;
	
	public string textToType
	{
		set { _textToType = value; }
	}

	private void OnEnable()
	{
		if(!_mainAudioSource)
		{
			Debug.Log("No AudioSource has been set. Set one if you wish you use audio features.");
		}
		
		_counter = 0;
		_textComponent.text = "";
		if(_startOnStart)
		{
			StartTyping();
		}
		Debug.Log(_textToType);
	}

	public void StartTyping()
	{	
		if(!_typing)
		{
			InvokeRepeating("Type", _startDelay, _typeSpeed);
		}
		else
		{
			Debug.LogWarning(gameObject.name + " : Is already typing!");
		}
	}

	public void StopTyping()
	{
        _counter = 0;
        _typing = false;
		CancelInvoke("Type");
	}
	
	private void Type()
	{	
		_typing = true;
		_textComponent.text = _textComponent.text + _textToType[_counter];
		_counter++;

		if(_mainAudioSource)
		{	
			_mainAudioSource.Play();
			RandomiseVolume();
		}

		if(_counter == _textToType.Length)
		{	
			_typing = false;
			CancelInvoke("Type");
		}
	}

    public void UpdateText(string newText)
    {   
        StopTyping();
        _textComponent.text = "";
        _textToType = newText;
        StartTyping();
    }

	public void QuickSkip()
	{
		if(_typing)
		{
			StopTyping();
			_textComponent.text = _textToType;
		}
	}

	

	private void RandomiseVolume()
	{
		_mainAudioSource.volume = Random.Range(1 - _volumeVariation, _volumeVariation + 1);
	}

    public bool IsTyping() { return _typing; }
}