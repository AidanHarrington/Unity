using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour {
    
    public  void LoadLevel(string levelName)
    {
        print("Loading Level " + levelName);
        //loads the scene
        SceneManager.LoadScene(levelName);
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
