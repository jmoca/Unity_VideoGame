using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameTimer : MonoBehaviour
{
    public float tiempoRestante = 350f; // 350 segundos
    public TMP_Text contadorTexto; // Referencia a un UI Text (opcional)

    void Update()
    {
        // Reducir tiempo
        tiempoRestante -= Time.deltaTime;

        // Mostrar tiempo en UI (si hay un Text asignado)
        if (contadorTexto != null)
        {
            contadorTexto.text = "Tiempo: " + Mathf.CeilToInt(tiempoRestante).ToString();
        }

        // Cuando el tiempo llega a 0, vuelve al menú
        if (tiempoRestante <= 0)
        {
            SceneManager.LoadScene("Menu Principal"); // Asegúrate de que el nombre es correcto
        }
    }
}
