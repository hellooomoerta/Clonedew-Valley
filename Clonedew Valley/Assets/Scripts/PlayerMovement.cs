using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Vector2 movement;
    private Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;
    private Animator myAnimator;
    private PlayerInput playerInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponentInChildren<SpriteRenderer>();
        myAnimator = GetComponentInChildren<Animator>();
        playerInput = new PlayerInput();
    }


    void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        Move();
        AdjustPlayerFacingDirection();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    void PlayerInput()
    {
        movement = playerInput.Movement.Move.ReadValue<Vector2>().normalized;

        myAnimator.SetFloat("moveX", movement.x);
        myAnimator.SetFloat("moveY", movement.y);
    }

    void Move()
    {
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }

    void AdjustPlayerFacingDirection()
    {
        if (movement.x < 0)
        {
            mySpriteRenderer.flipX = true;
        }
        else if (movement.x > 0)
        {
            mySpriteRenderer.flipX = false;
        }
    }
}
