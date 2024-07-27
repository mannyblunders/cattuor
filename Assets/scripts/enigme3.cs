using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class enigme3 : MonoBehaviour
{
   
    [SerializeField] private DoorControl doorControl; // Reference to the door control script
    [SerializeField] private Portaltolevel2 portaltolevel2; // ?????
    [SerializeField] private DialogueTrigger dialogueTrigger; // Reference to the dialogue trigger script


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Player"))
        {

            dialogueTrigger.TriggerDialogue(); // Trigger the dialogue
            doorControl.OpenDoor(); // Optionally open the door
            
        }
    }
}
