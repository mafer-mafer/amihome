using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour {

	public string nextScene;

	public void changeScene (){
		SceneManager.LoadScene (nextScene);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
