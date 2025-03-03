using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Método para iniciar el juego
    public void JugarJuego()
    {
        SceneManager.LoadScene("JuegoCompleto"); // Cargar la escena del juego
    }

    // Método para salir del juego
    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego..."); // Mensaje en consola (solo visible en el editor)
        Application.Quit(); // Cierra el juego (solo funciona en la versión compilada)
    }

    // Método para volver al menú principal
    public void IrAlMenu()
    {
        SceneManager.LoadScene("Menu Principal"); // Cargar la escena del menú principal
    }
}
