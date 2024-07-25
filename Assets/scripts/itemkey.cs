using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemkey : MonoBehaviour
{
    public bool istaken = false;
    public void collect() 
    {
        istaken = true;
       gameObject.SetActive(false);//faire disparaitre l'item key

    }

}
