using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    [SerializeField] float speed, horizontalMovement;

    private Rigidbody2D rigidbodyPlayer;
    private Vector2 playerSpeed;

    private Animator animation;
    private SpriteRenderer sprite;
    [SerializeField] private AudioSource runSoundEffect;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMovement = Input.GetAxis("Horizontal");
        if(rigidbodyPlayer.velocity.x != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if(isMoving)
        {
            if(!runSoundEffect.isPlaying)
            {
                runSoundEffect.Play();
            }
        }
        else
        {
            runSoundEffect.Stop();
        }
        //rigidbodyPlayer.velocity = new Vector2(horizontalMovement * speed, rigidbodyPlayer.velocity.y);

        //playerSpeed = new Vector2(horizontalMovement, 0f);
        GetMovementSpeed();
        Walk();
        playerAnimation();

    }

    private void FixedUpdate()
    {
        rigidbodyPlayer.MovePosition(rigidbodyPlayer.position + playerSpeed * speed * Time.fixedDeltaTime);
    }

    private void GetMovementSpeed()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        playerSpeed = new Vector2(horizontalMovement, 0f);
    }

    private void Walk()
    {
        rigidbodyPlayer.velocity = (new Vector2(playerSpeed.x * speed, rigidbodyPlayer.velocity.y));
    }

    private void playerAnimation()
    {
        if(horizontalMovement > 0f)
        {
            animation.SetBool("Running", true);
            sprite.flipX = true;
        }

        else if(horizontalMovement < 0f)
        {
            animation.SetBool("Running", true);
            sprite.flipX = false;
        }

        else
        {
            animation.SetBool("Running", false);
        }
    }
}
