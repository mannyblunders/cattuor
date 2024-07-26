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
        //animator.SetBool("startOpen", true);
        dialogButton.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        dialogButton.SetActive(false);
        //animator.SetBool("startOpen", false);
        dm.EndDialogue();
    }
}
