using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorControl : AudioS
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetTrigger("Open");
        PlaySound(sounds[0]);
    }
}
   
    

