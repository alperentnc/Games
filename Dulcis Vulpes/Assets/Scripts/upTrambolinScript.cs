using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upTrambolinScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    Rigidbody2D rb;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("touching");
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -15), ForceMode2D.Impulse);
        }
    }
}
