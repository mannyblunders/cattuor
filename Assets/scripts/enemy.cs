using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("SampleScene");
    }
    void Start()
    {
        // Add attack later
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
