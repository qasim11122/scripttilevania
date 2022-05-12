using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float movespeed = 5f;
    [SerializeField] float jumheight = 8f;
    Rigidbody2D rb;
    Animator anim;
    CapsuleCollider2D mycapsuleCollider;
    public GameObject myprefab;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        mycapsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector3(-1, 1, 1);

        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            anim.SetBool("isRunning", false);
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (mycapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                rb.AddForce(Vector2.up * jumheight, ForceMode2D.Impulse);
            }
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(myprefab, transform.position, transform.rotation);
            Debug.Log("bullet");
        }
    }
}
