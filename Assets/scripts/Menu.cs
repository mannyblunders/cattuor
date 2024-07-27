using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button play;
    public Button exit;
    public void StartGame()
    {
        SceneManager.LoadScene("Scene1 sophie");
    }
    
    public void OnExitButtonClick()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
