using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
	public void ReturnToGame()
	{
		SceneManager.LoadScene("Main Menu");
	}
	
	public void ExitGame()
	{
		Application.Quit();
	}
}
