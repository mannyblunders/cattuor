using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : AudioS
{
    //public void ReloadCurrentScene()
    //{

    //    Scene currentScene = SceneManager.GetActiveScene();

    //    SceneManager.LoadScene(currentScene.name);
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(1);
            PlaySound(sounds[0]);
        }
    }
}
