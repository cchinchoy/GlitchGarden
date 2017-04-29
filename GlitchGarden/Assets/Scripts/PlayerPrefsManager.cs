using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_UNLOCK_KEY = "level_unlock_";

	public static void SetMasterVolume(float volume){
		if(volume >= 0f && volume <= 1f){
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		}else {
			Debug.LogError("Volume out of Range");
		}
	}
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}
	public static void SetDifficulty(float diff){
		if (diff >= 1f && diff <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, diff);
		} else {
			Debug.LogError ("Difficulty Value out of Range");
		}
	}
	public static float GetDifficulty(){
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	public static void UnlockLevel(int level){
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_UNLOCK_KEY + level.ToString(), 1);
		} else {
			Debug.LogError ("Level Does Not Exist");
		}
	}
	public static bool IsLevelUnlocked(int level){
		int unlockCheck = PlayerPrefs.GetInt (LEVEL_UNLOCK_KEY+level.ToString());
		bool isLevelUnlocked = (unlockCheck==1);
		if (level <= Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			return false;
		}
	}
}
