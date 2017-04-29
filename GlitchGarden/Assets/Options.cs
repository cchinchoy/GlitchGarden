using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Options : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
		Debug.LogError ("From Start: "+volumeSlider.value);
		Debug.LogError ("From Start: "+difficultySlider.value);
	}
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);
		Debug.LogError ("From Update: "+volumeSlider.value);
		Debug.LogError ("From Update: "+difficultySlider.value);
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
	}
	public void SaveandExit(){
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		Debug.LogError ("From Save and Exit: "+volumeSlider.value);
		Debug.LogError ("From Save and Exit: "+difficultySlider.value);
		levelManager.LoadLevel ("01a Start Menu");
	}
	public void SetDefaults(){
		volumeSlider.value = .8f;
		difficultySlider.value = 2f;
	}
}
