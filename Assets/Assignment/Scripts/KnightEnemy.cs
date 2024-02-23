using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightEnemy : MonoBehaviour
{

    Vector2 destination;
    Vector2 movement;
    public float speed = 3f;
    public float maxHealth = 3;
    public float health;
    bool isDead;

    Rigidbody2D rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = maxHealth;
        isDead = false;

        destination.x = Random.Range(-10, 10);

    }

    private void FixedUpdate()
    {
        if (isDead) return;

        movement = destination - (Vector2)transform.position;

        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }

        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) return;

        if (rb.position.y > 1)
        {
            destination.y = -3;
        }

        if (rb.position.y <= 1)
        {
            animator.SetTrigger("Attack");
        }

        animator.SetFloat("Walking", movement.magnitude);
    }
}
