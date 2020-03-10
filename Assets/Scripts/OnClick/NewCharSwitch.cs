using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; 

public class NewCharSwitch : MonoBehaviour {
    public void NextScene() {
    	Debug.Log("Scene switching : NewCharacter");
        SceneManager.LoadScene("NewCharacter");
    }
}