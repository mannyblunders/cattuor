using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        
        Scene currentScene = SceneManager.GetActiveScene();
        
        SceneManager.LoadScene(currentScene.name);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cat"))
            {
            ReloadCurrentScene();
            }
        
    }
    //dZVS
    void Start()
    {
    }
    void Update()
    {
        
    }
}
