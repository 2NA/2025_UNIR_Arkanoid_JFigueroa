using UnityEngine.InputSystem;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 360f;
    [SerializeField] private float horizontalSpeed = 100f;

    Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Keyboard.current.spaceKey.IsPressed())
        // {
        //     transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime); 
        // }

        if (Keyboard.current.aKey.IsPressed())
        {
            // transform.position += Vector3.left * horizontalSpeed * Time.deltaTime;
            rb2d.linearVelocity = Vector2.left * horizontalSpeed;
        }
        else if (Keyboard.current.dKey.IsPressed())
        {
            // transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
            rb2d.linearVelocity = Vector2.right * horizontalSpeed;
        }
        else
        {
            rb2d.linearVelocity = Vector2.zero;
        }
    }
}
