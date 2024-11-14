using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Transform objekto, kurį kamera seks (tavo rutulio)
    public Vector3 offset;   // Pozicijos skirtumas tarp kameros ir rutulio
    public float smoothSpeed = 0.125f; // Lyginimo greitis

    void LateUpdate()
    {
        // Apskaičiuok naują kamerų poziciją
        Vector3 desiredPosition = target.position + offset;

        // Lygiai judink kamerą link naujos pozicijos
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Kamera visada bus nukreipta į rutulį
        transform.LookAt(target);
    }
}
