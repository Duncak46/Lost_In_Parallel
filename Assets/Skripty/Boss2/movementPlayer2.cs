using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementPlayer2 : MonoBehaviour
{
    public static bool hraZapnuta2 = false;
    public float walkSpeed;
    private float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public LayerMask groundMask;

    public PhysicsMaterial2D bounceMat, normalMat;
    public bool canJump;
    public float jumpValue;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hraZapnuta2 == true)
        {
            moveInput = Input.GetAxisRaw("Horizontal");
            if (jumpValue == 0.0f && isGrounded)
            {
                rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);
            }

            isGrounded = Physics2D.OverlapBox(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f), new Vector2(0.9f, 0.4f), 0f, groundMask);

            if (jumpValue > 0)
            {
                rb.sharedMaterial = bounceMat;
            }
            else
            {
                rb.sharedMaterial = normalMat;

            }
            if (Input.GetKey("space") && isGrounded && canJump)
            {
                jumpValue += 0.25f;
                rb.velocity = new Vector2(0.0f, rb.velocity.y);
            }
            if (jumpValue > 35f && isGrounded)
            {
                float tempx = moveInput * walkSpeed;
                float tempy = jumpValue;
                rb.velocity = new Vector2(tempx, tempy);
                Invoke("ResetJump", 0.2f);
            }
            if (Input.GetKeyUp("space"))
            {
                if (isGrounded)
                {
                    rb.velocity = new Vector2(moveInput * walkSpeed, jumpValue);
                    jumpValue = 0.0f;
                }
                canJump = true;
            }
        }
        
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f), new Vector2(0.9f, 0.2f));
    }
    void ResetJump()
    {
        canJump = false;
        jumpValue = 0;
    }
}
