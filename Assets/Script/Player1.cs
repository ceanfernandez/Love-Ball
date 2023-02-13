using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb;
    private Vector2 racketDirection;
    



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directonY = Input.GetAxisRaw("Vertical");
        racketDirection = new Vector2(0, directonY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = racketDirection * speed;

    }

    
}
