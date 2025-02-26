using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform respawnPoint; // Punto donde reaparecerá el jugador

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Si el jugador cae en la zona de muerte
        {
            collision.transform.position = respawnPoint.position; // Lo mueve al respawn point
        }
    }
}
