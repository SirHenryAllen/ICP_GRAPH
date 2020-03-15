using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; 

public class MainMenuSwitch : MonoBehaviour {
    public void NextScene() {
    	Debug.Log("Scene switching to : Menu");
        SceneManager.LoadScene("Menu");
    }
}