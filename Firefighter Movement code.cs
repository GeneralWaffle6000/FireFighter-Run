using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 0.5f;
    private Rigidbody2D rb;
    private Vector2 input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame - used for input and timers
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");


        input.Normalize(); //makes our diagonal movement move the same as other movements
    }

    //Called once per physics frame - used for physics (We'll use for our movement)
    private void FixedUpdate()
    {
        rb.linearVelocity = input * speed;
    }
}
