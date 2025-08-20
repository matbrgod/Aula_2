using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
//using TMPro;

public class ItemControl : MonoBehaviour
{
    public int coins;
    public int health;
    public int maxHealth = 5;
    public AudioSource coinAudioSource;   // For coin sound
    public AudioSource enemyAudioSource;  // For enemy sound
    public TMP_Text healthText;
    public TMP_Text coinsText;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.4f, 128);
        if (collision)
        {
            coins++;
            coinAudioSource.Play(); // Play coin sound
            Destroy(collision.gameObject);
        }

        Collider2D collision1 = Physics2D.OverlapCircle(transform.position, 0.4f, 256);
        if (collision1)
        {
            enemyAudioSource.Play(); // Play enemy sound
            health -= 1;
            Destroy(collision1.gameObject);
            if (health <= 0)
            {
                //print("Game Over");
                SceneManager.LoadScene("GameOver");
            }
        }

        if (coins >= 34)
        {
            SceneManager.LoadScene("Win");
        }
        healthText.text = "Health: " + health;
        coinsText.text = "Coins: " + coins;
    }

    
}