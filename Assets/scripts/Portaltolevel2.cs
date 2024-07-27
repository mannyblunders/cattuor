using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portaltolevel2 : MonoBehaviour
{
    SpriteRenderer sr;
    public bool Gettingaway = false;

    public bool GiveItemBack = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && GiveItemBack)
        {
            SceneManager.LoadScene("Scene3 Final");
        }
        
    }
    
}
