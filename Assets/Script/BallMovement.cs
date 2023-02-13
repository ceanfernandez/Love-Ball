using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public float extraSpeed;
    public float maxExtraSpeed;

    private int hitCounter=0;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    public IEnumerator Launch()
    {
        hitCounter = 0;
        yield return new WaitForSeconds(1);
        MoveBall(new Vector2(-1, 0));

    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = speed + hitCounter * extraSpeed;
        rb.velocity = direction * ballSpeed;
        Debug.Log("helo");
    }
    public void IncreaseCounter()
    {
        if (hitCounter * extraSpeed < maxExtraSpeed)

        {
            hitCounter++;
        };

    }
}
