using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [Header("Vida del Enemigo")]
    public int maxHealth = 10;
    private int currentHealth;

    [Header("Movimiento")]
    public float speed = 2f; // Velocidad del enemigo
    private Vector3 startPosition; // Posición de inicio del movimiento
    private float moveRange = 5f; // Distancia máxima en X
    private bool movingRight = true; // Controla la dirección del movimiento

    [Header("Respawn del Jugador")]
    public Transform respawnPoint;
    public float respawnTime = 2f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        currentHealth = maxHealth; // Inicializa la vida del enemigo
        startPosition = transform.position; // Guarda la posición de inicio
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Movimiento hacia la derecha o izquierda
        float targetX = movingRight ? startPosition.x + moveRange : startPosition.x - moveRange;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(targetX, transform.position.y), speed * Time.deltaTime);

        // Cambia la dirección si llega al límite
        if (Vector2.Distance(transform.position, new Vector2(targetX, transform.position.y)) < 0.1f)
        {
            movingRight = !movingRight; // Cambia la dirección
        }

        // Voltear sprite según la dirección del movimiento
        spriteRenderer.flipX = movingRight;
    }

    // Detecta cuando el jugador golpea al enemigo
    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Player")) 
    {
        // Si el enemigo toca al jugador, lo manda al respawn
        StartCoroutine(RespawnPlayer(collision.gameObject));
    }
    else if (collision.CompareTag("AttackZone")) 
    {
        // Si el jugador está atacando, mata al enemigo
        Die();
    }
}


    // Método para destruir al enemigo instantáneamente
    public void Die()
    {
        gameObject.SetActive(false);
    }

    // Respawn del jugador (no es necesario cambiar)
    IEnumerator RespawnPlayer(GameObject player)
    {
        player.SetActive(false);
        yield return new WaitForSeconds(respawnTime);
        player.transform.position = respawnPoint.position; // Respawn en el punto especificado
        player.SetActive(true);
    }
}
