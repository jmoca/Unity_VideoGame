using UnityEngine;
using UnityEngine.SceneManagement;

public class PuntoFinal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que entró es el jugador
        if (other.CompareTag("Player"))
        {
            // Carga el menú principal
            SceneManager.LoadScene("PantallaFinal");
        }
    }
}
