using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float sprintSpeed = 7f; // Speed of the player movement
    private float jumpForce = 6f; // Force applied when jumping
    public float speed = 5f; // Speed of the player movement
    private Rigidbody2D playerRb;
    private float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove();
        Jump();
    }

    // Method to handle horizontal movement
    void HorizontalMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(horizontalInput * sprintSpeed * Time.deltaTime * Vector2.right);
        }
        else
        {
            transform.Translate(horizontalInput * speed * Time.deltaTime * Vector2.right);
        }
    }

    // Method to handle jumping
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
