using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
	public AudioMixer audioMixer;
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public string outputMenu = "MainScene";

	 void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){
			if(GameIsPaused){
				Resume();
			}else{
				Pause();
			}
		}
	}

	 void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale =1f;
		GameIsPaused = false;
	}

	 void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale =0f;
		GameIsPaused = true;
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(outputMenu);
		Time.timeScale =1f;
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void SetVolume(float volume)
	{
		audioMixer.SetFloat("volum", volume);
	}
}
