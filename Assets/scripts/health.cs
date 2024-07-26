using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private float damage;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);

        if (currentHealth < startingHealth)
        {
            //player hurt
        }
        else
        {
            //player dead
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) ;
        TakeDamage(1);
    }

}
