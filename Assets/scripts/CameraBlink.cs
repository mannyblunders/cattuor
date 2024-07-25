using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBlink : MonoBehaviour

{
    [SerializeField] GameObject on;
    [SerializeField] GameObject off;
    [SerializeField] float blinkTime = 1;
    float blinkTimer = 0;
    bool isOn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blinkTimer += Time.deltaTime;
        if (blinkTimer > blinkTime)
        {
            blinkTimer = 0;
            isOn = !isOn;
        }

        on.SetActive(isOn);
        off.SetActive(!isOn);
    }
}
