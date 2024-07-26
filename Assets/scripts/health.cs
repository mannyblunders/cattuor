using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }//ony changed by me 
    private Animator anim;
    private bool dead;
    [SerializeField] private GameObject gameOverScreen; // Reference to the game over screen UI

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                //GetComponent<PlayerMovement>().enabled = false;
                dead = true;
                ShowGameOverScreen();
            }
        }
    }

    private void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true); // Show the game over screen
        Time.timeScale = 0f; // Pause the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Resume the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart the current scene
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f; // Resume the game
        SceneManager.LoadScene("Menu"); // Load the main menu scene (ensure you have a scene named "MainMenu")
    }
}
