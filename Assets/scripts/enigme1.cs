using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class enigme1 : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] itemkey itemkey; //je peux en mettre plus, plus tard

    private bool GettingAway = false;

    private void Update()
    {
        if (GettingAway)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + Speed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Player") && itemkey.istaken)
        {
            GettingAway = true;
        }
    }
}
