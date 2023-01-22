using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostscript : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb, playerRb;
    float ghostVc;
    Animator ghost;
    public playerMovement pM;
    Collider2D floorCol;
    Vector2 firstPos,oldPos;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        playerRb = player.GetComponent<Rigidbody2D>();
        firstPos = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        ghostVc += Time.deltaTime/2;
        if (transform.position.x < player.transform.position.x && ghostVc <= 60)
        {
            rb.velocity = new Vector2((ghostVc/4) + 4, rb.velocity.y);
        }
        else if(transform.position.x < player.transform.position.x && ghostVc > 60)
        {
            rb.velocity = new Vector2(19, rb.velocity.y);
        }
        if (pM.gameOverBool == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    private void FixedUpdate()
    {
        floorCol = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y - 0.5f), 0.1f, LayerMask.GetMask("Floor"));
        if (player.transform.position.y - transform.position.y >= 0.3f)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);

        }

        else if (player.transform.position.y - transform.position.y < -0.3f)
        {
            rb.velocity = new Vector2(rb.velocity.x, -5);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }
}
