using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float ballVelocity = 20f;
    [SerializeField] Vector2 startDirection = (Vector2.up + Vector2.left).normalized;

    Rigidbody2D rb2d;

    Vector3 startPosition;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    private void OnEnable()
    {
        rb2d.linearVelocity = startDirection.normalized * ballVelocity;
    }

    private void FixedUpdate()
    {
        rb2d.linearVelocity = rb2d.linearVelocity.normalized * ballVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ResetToStart()
    {
        transform.position = startPosition;
        rb2d.linearVelocity = startDirection.normalized * ballVelocity;
    }
}
