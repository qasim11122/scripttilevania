using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    [SerializeField] float movespeed = 2f;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(movespeed, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        movespeed = -movespeed;
        transform.localScale=new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)), 1);
    }
}
