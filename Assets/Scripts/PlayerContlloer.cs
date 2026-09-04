using UnityEngine;

public class PlayerContlloer : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody rb;

    void Start() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        float moveH = Input.GetAxisRaw("Horizontal");
        float moveV = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveH, 0.0f, moveV).normalized; // 斜め移動で速くならないように正規化

        if (movement.magnitude > 0)
        {
            rb.linearVelocity = movement * speed;
        }
        else
        {
            rb.linearVelocity = Vector3.zero;
        }
    }
}
