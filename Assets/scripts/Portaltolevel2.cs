using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portaltolevel2 : MonoBehaviour
{
    SpriteRenderer sr;
    public bool Gettingaway = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Gettingaway == true)
        {
            SceneManager.LoadScene("Scene3 Final");
        }
        
    }
    
}
