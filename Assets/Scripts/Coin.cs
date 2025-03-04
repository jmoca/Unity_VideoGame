using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points = 10; // Puntos que da la moneda
    public AudioClip MonedaSonido; // Sonido de la moneda

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);

        if (collision.CompareTag("Player")) 
        {
            Debug.Log("Moneda recogida, sumando puntos...");
            
            // Reproducir sonido
            if (MonedaSonido != null)
            {
                AudioSource.PlayClipAtPoint(MonedaSonido, transform.position);
            }
            
            GameManager.instance.AddScore(points); // Sumar puntos
            Destroy(gameObject); // Destruir la moneda
        }
    }
}
