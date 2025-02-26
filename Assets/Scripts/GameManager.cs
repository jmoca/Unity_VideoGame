using UnityEngine;
using TMPro; // Para mostrar la puntuación en la UI

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton para acceso global
    public int score = 0; // Puntuación inicial
    public TextMeshProUGUI scoreText; // Referencia al texto de la UI

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points; // Sumar puntos
        UpdateScoreText(); // Actualizar la UI
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntos: " + score;
        }
    }
}
