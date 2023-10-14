using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float horizontal_input;
    [SerializeField] private float jump_power;
    private bool is_facing_right;

    private bool isinair;

    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Transform ground_check_object;
    [SerializeField] private LayerMask Ground_layer;
    [SerializeField] private Animator _animator;

    //audio
    [SerializeField] private AudioSource jump;


    // Update is called once per frame
    void Update()
    {
        horizontal_input = Input.GetAxisRaw("Horizontal");
        Flip_player();

        //sets is in air to the oppisite of isgrounded
        isinair = !is_grounded();

        //sets the animation state to whatever the opposite of isgrounded's value is
        _animator.SetBool("Is_in_air", isinair);

        if (Input.GetButtonDown("Jump") && is_grounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jump_power);
            jumpsfx();
        }

        if (Input.GetButtonUp("Jump") && rb2d.velocity.y > 0f)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(horizontal_input * speed, rb2d.velocity.y);
        _animator.SetFloat("Speed", rb2d.velocity.x);
    }

    private void Flip_player()
    {
        if (is_facing_right && horizontal_input < 0f || !is_facing_right && horizontal_input > 0f)
        {
            is_facing_right = !is_facing_right;
            Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        }
    }

    private bool is_grounded()
    {
        return Physics2D.OverlapCircle(ground_check_object.position, 0.4f, Ground_layer);
    }

    public void jumpsfx()
    {
        if (jump.isPlaying == false)
        {
            jump.Play();
        }
    }
}
