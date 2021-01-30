using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
	public string firstlevel;
	public void gotofirstlevel()
	{
		SceneManager.LoadScene(firstlevel);
	}
	public void exit()
	{
		Application.Quit();
	}
}
