using UnityEngine;
using System.Collections; // Necesario para usar Corrutinas

public class Enemy : MonoBehaviour
{
    public Transform respawnPoint; // Referencia al punto de reaparición
    public float respawnTime = 2f; // Tiempo de espera antes de reaparecer

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Verifica si es el jugador
        {
            StartCoroutine(RespawnPlayer(collision.gameObject)); // Llama a la corrutina de reaparición
        }
    }

    IEnumerator RespawnPlayer(GameObject player)
    {
        player.SetActive(false); // Oculta al jugador temporalmente
        yield return new WaitForSeconds(respawnTime); // Espera el tiempo definido
        player.transform.position = respawnPoint.position; // Mueve al jugador al punto de reaparición
        player.SetActive(true); // Reactiva al jugador
    }
}
