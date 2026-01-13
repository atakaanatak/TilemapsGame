using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector3 initialSize;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialSize = transform.localScale;
    }
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
        if (move > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(initialSize.x), initialSize.y, initialSize.z);
        }
        else if (move < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(initialSize.x), initialSize.y, initialSize.z);
        }
    }
}