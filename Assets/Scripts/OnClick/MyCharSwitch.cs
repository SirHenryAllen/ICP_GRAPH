using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; 

public class MyCharSwitch : MonoBehaviour {
    public void NextScene() {
    	Debug.Log("Scene switching : MyCharacters");
        SceneManager.LoadScene("MyCharacters");
    }
}