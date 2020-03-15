using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitOnClick : MonoBehaviour
{
	public void quit() {
		Debug.Log("Quitting game");
		Application.Quit();
	}
}
