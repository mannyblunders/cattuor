using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button play;
    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
