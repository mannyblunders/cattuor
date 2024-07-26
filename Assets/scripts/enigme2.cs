using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class enigme2 : MonoBehaviour
{
    [SerializeField] itemkey itemkey; //je peux en mettre plus, plus tard
    [SerializeField] private DoorControl doorControl; // Reference to the door control script
    [SerializeField] private Portaltolevel2 portaltolevel2; // ?????
    [SerializeField] private DialogueTrigger dialogueTrigger; // Reference to the dialogue trigger script


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Player") && itemkey.istaken)
        {
            GiveItemBack();

        }
    }

    private void GiveItemBack()
    {
        itemkey.istaken = false; // Mark the item as not taken
        dialogueTrigger.TriggerDialogue(); // Trigger the dialogue
        doorControl.OpenDoor(); // Optionally open the door
    }
}
