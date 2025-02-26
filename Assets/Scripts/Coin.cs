using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points = 10; // Puntos que da la moneda

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);

        if (collision.CompareTag("Player")) 
        {
            Debug.Log("Moneda recogida, sumando puntos...");
            GameManager.instance.AddScore(points); // Sumar puntos
            Destroy(gameObject); // Destruir la moneda
        }
    }
}
