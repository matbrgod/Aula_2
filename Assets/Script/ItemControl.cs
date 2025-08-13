using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public int coins;
    public int health;
    public int maxHealth = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 128);
        if (collision)
        {
            coins++;

            Destroy( collision.gameObject );   
        }
    }
}
