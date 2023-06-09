using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer sr;
    float moveSpeed = 0.8f;
    private Rigidbody2D body;
    private Animator animator;
    private GameObject controller;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        controller = GameObject.FindGameObjectWithTag("GameController");
    }

    public float speed;


    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Sprite Renderer Logic
        if (horizontalInput > 0)
        {
            sr.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            sr.flipX = true;
        }

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {

    }



}