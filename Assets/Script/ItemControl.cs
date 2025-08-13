using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemControl : MonoBehaviour
{
    public int coins; // Number of coins collected
    public int health; // Health of the player
    public int maxHealth = 100; // Maximum health of the player
    AudioSource audioSource; // AudioSource to play sound effects

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 128);
        if (collision)
        {
            coins++; // Increment coins when colliding with a coin item
            audioSource.Play(); // Play the coin collection sound
            Destroy(collision.gameObject); // Destroy the coin item after collecting it
        }

        Collider2D collision1 = Physics2D.OverlapCircle(transform.position, 0.1f, 256);
        if (collision1)
        {
            maxHealth -= 100; // Decrement health when colliding with an enemy
            Destroy(collision1.gameObject); // Destroy the enemy after colliding with it
            print("Game Over");
            SceneManager.LoadScene("GameOver");

        }

    }
}