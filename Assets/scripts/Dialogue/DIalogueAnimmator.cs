using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIalogueAnimmator : MonoBehaviour
{
    //public Animator animator;
    public DialogueMAnager dm;
    public GameObject dialogButton;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (dialogButton != null)
        {
            dialogButton.SetActive(true);
        }
        else
        {
            Debug.LogWarning("dialogButton is null in OnTriggerEnter2D");
        }

        //animator.SetBool("startOpen", true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (dialogButton != null)
        {
            dialogButton.SetActive(false);
        }
        else
        {
            Debug.LogWarning("dialogButton is null in OnTriggerExit2D");
        }

        if (dm != null)
        {
            dm.EndDialogue();
        }
        else
        {
            Debug.LogWarning("DialogueManager (dm) is null in OnTriggerExit2D");
        }

        //animator.SetBool("startOpen", false);
    }
}