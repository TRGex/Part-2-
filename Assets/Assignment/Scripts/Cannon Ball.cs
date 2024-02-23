using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class CannonBall : MonoBehaviour
{
    public float speed = 3f;
    public GameObject Ball;
    public Transform spawn;


    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 15 * Time.deltaTime, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }


    //private void FixedUpdate()
    //{
    //    Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
    //    rb.MovePosition(rb.position + direction);
    //}
}
