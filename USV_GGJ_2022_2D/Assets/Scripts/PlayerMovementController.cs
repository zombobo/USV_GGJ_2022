using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2;

    private new Rigidbody2D rigidbody2D;

    public float hSpeed { get; private set; }
    public float vSpeed { get; private set; }

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        hSpeed = horizontal;
        float vertical = Input.GetAxis("Vertical");
        vSpeed = vertical;

        Vector3 Movement = new Vector3(horizontal, vertical).normalized;
      

        transform.position += Movement * Time.deltaTime * moveSpeed;
    }
}
