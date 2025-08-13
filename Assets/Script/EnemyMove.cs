using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 2f;              // Velocidade do movimento
    private Vector2 direction = Vector2.up; // Começa indo para cima

    void Update()
    {
        // Move o inimigo na direção atual
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Inverte a direção ao colidir com qualquer coisa

        direction = -direction;
    }
}
