using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private Transform player; 
    public Vector3 offset = new Vector3(0, 5, -7); 
    public float smoothSpeed = 0.5f;

    private void LateUpdate()
    {
        if (player == null) return;
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }


}
