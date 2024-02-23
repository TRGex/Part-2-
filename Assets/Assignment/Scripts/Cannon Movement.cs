using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
   
    Vector2 cannonPosition;
    Vector2 movement;
    public float speed = 5f;
    public GameObject cannonBall;
    public Transform ballSpawn;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        cannonPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(cannonBall, ballSpawn.position, ballSpawn.rotation);
        }

    }

    private void FixedUpdate()
    {
        movement = cannonPosition - (Vector2)transform.position;
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}
