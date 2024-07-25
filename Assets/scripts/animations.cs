using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class animations : MonoBehaviour
{
    private Animator animator; 

    public bool torun { private get; set; }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        animator.SetBool("torun", torun); 
    }
}
