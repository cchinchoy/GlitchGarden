using UnityEngine;
using System.Collections;

public class MenuLevelLoader : MonoBehaviour {

	public float LoadNextLevelAfter;

	void Start(){
		Invoke ("LoadNextLevel", LoadNextLevelAfter);
	}
	public void LoadNextLevel(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
