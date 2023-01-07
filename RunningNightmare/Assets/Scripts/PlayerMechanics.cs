using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    [SerializeField] float speed, horizontalMovement, verticalMovement;
    [SerializeField] private LayerMask jumpableGround;

    private Rigidbody2D rigidbodyPlayer;
    private BoxCollider2D playerCollider;
    private Vector2 playerSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        GetMovementSpeed();
        Walk();
    }

    private void FixedUpdate()
    {
        rigidbodyPlayer.MovePosition(rigidbodyPlayer.position + playerSpeed * speed * Time.fixedDeltaTime);
    }

    private void GetMovementSpeed()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        playerSpeed = new Vector2(horizontalMovement, verticalMovement);
    }

    private void Walk()
    {

        rigidbodyPlayer.velocity = (new Vector2(playerSpeed.x * speed, rigidbodyPlayer.velocity.y));
    }
}
