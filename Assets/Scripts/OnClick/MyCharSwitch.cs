using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; 

public class MyCharSwitch : MonoBehaviour {
    public void NextScene() {
    	Debug.Log("Scene switching to : MyCharacters");
        SceneManager.LoadScene("MyCharacters");
    }
}