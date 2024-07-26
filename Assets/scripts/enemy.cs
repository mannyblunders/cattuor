using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        // ???????? ??????? ?????
        Scene currentScene = SceneManager.GetActiveScene();
        
        SceneManager.LoadScene(currentScene.name);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ReloadCurrentScene();
    }
    //dZVS
    void Start()
    {
        // Add attack later
        //fgklzxj;ga
        //maybe i should do it now 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
