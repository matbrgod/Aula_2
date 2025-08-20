using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{
    public float speed = 2f;              // Velocidade do movimento
    private Vector2 direction = Vector2.left; // Começa indo para cima

    void Update()
    {
        // Move o inimigo na direção atual
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin")||collision.gameObject.CompareTag("Enemy"))
        {
            return; // Não inverte a direção ao colidir com uma moeda
        }
        else 
        {
            // Inverte a direção ao colidir com uma parede
            direction = -direction;
        }
        // Inverte a direção ao colidir com qualquer coisa
    }
}
