using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public Vector3 offset = new Vector3(0f, 2f, -10f); // Desplazamiento de la cámara respecto al jugador
    public float smoothSpeed = 5f; // Velocidad de suavizado

    void LateUpdate()
    {
        if (player != null)
        {
            // Posición deseada de la cámara con interpolación suave
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}
