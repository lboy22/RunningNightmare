using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    [SerializeField] float speed, horizontalMovement, verticalMovement;
    [SerializeField] private LayerMask jumpableGround;

    private Rigidbody2D rigidBodyPlayer;
    private BoxCollider2D playerCollider;
    private Vector2 playerSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyPlayer = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed.x = Input.GetAxis("Horizontal");
        playerSpeed.y = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        rigidBodyPlayer.MovePosition(rigidBodyPlayer.position + playerSpeed * speed * Time.fixedDeltaTime);
    }
}
