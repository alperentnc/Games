using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    Collider2D floorCol;
    public Slider chargeFill;
    public GameObject explosion;
    public Button replaybtn;
    public Text replaytxt,scoretxt;
    public Image lightning;


    public bool crouchCheck, gameOverBool=false,chargedBool, jumping;
    float chargeCd,velocityTimer,counter,score;

    Transform checkTransform;

    BoxCollider2D standCollider, crouchCollider;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        chargeCd = 0; velocityTimer = 0;  chargeFill.value = 100;counter = 0;
        crouchCheck = false; gameOverBool = false; chargedBool = false; jumping = false;

        standCollider = GetComponent<BoxCollider2D>();
        crouchCollider = transform.GetChild(0).GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2((velocityTimer / 4) + 4, rb.velocity.y);
        score =counter*velocityTimer;
        scoretxt.text =""+(int)score;
        replaytxt.text = "OYUN   BITTI \n SKOR :" + scoretxt.text;
        floorCol = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y - 0.5f), 0.1f, LayerMask.GetMask("Floor"));
        if (gameOverBool == false) { counter += Time.deltaTime * 3; }
        if (velocityTimer <= 90 && gameOverBool == false)
        {
            velocityTimer += Time.deltaTime / 2;
        }
        if (chargeCd > 0)
        {
            if (gameOverBool == false) {
            chargeCd -= Time.deltaTime;
            chargeFill.value = (10 - chargeCd) * 10;
            lightning.gameObject.SetActive(true);
            }
        }
        else
        {
                if ((int)counter % 2 == 0)
                {
                    lightning.gameObject.SetActive(false);
                }

                else
                {
                    lightning.gameObject.SetActive(true);
                }

        }

        if (Input.GetAxisRaw("Vertical") == 1)
        {
            jump();
        }

        if (Input.GetAxisRaw("Vertical") == -1)
        {
            crouch();
            crouchCheck = true;
        }

        else if(Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y + 0.3f), 0.1f, LayerMask.GetMask("Floor")) == null)
        {
            stand();
            crouchCheck = false;
        }

        if (Input.GetAxisRaw("Horizontal") == 1 && chargeCd <= 0){

            charge();
        }

        if (transform.position.y <= -4.2f || transform.position.y>=6)
        {
            gameOver();
        }

        checkAnimations();

    }

    void checkAnimations()
    {
        if (!animator.GetBool("isJumping") && !animator.GetBool("isFalling") && !animator.GetBool("isCharging") &&
            !animator.GetBool("isCrouched") && !animator.GetBool("isDead"))
        {
            animator.SetBool("isRunning", true);
        }

        if (rb.velocity.y > 0.3f)
        {
            animator.SetBool("isJumping", true);
        }

        else
        {
            animator.SetBool("isJumping", false);
            jumping = false;
        }

        if (rb.velocity.y < 0.3f)
        {
            animator.SetBool("isFalling", true);
        }

        else
        {
            animator.SetBool("isFalling", false);
        }

        if (rb.velocity.y == 0)
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
        }

        if (crouchCheck)
        {
            animator.SetBool("isCrouched", true);
        }

        else
        {
            animator.SetBool("isCrouched", false);
        }

        if (gameOverBool)
        {
            animator.SetBool("isDead", true);
        }

    }

    void jump()
    {
        if (floorCol != null && !jumping && !crouchCheck)
        {
            rb.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
            jumping = true;
        }

    }

    void charge()
    {
        if (gameOverBool == false) {
        chargeCd = 10; chargeFill.value = 0;
        Vector2 oldpos = transform.position;
        RaycastHit2D hit = Physics2D.Raycast(oldpos, Vector2.right, 10, LayerMask.GetMask("Floor"));
        RaycastHit2D hitenemy = Physics2D.Raycast(oldpos, Vector2.right, 10, LayerMask.GetMask("ghost"));
        chargedBool = true;
        GameObject exp = (GameObject)Instantiate(explosion, new Vector2(oldpos.x + 5, transform.position.y), Quaternion.identity);
        Destroy(exp, 0.5f);
        if (hit.collider == null)
        {
            transform.position = new Vector2(transform.position.x + 10, transform.position.y);
            chargedBool = false;
        }
        else if(hit.collider.tag != "Enemy")
        {
            chargedBool = false;
            transform.position = new Vector2(hit.collider.gameObject.transform.position.x-hit.collider.gameObject.GetComponent<BoxCollider2D>().bounds.size.x/2,transform.position.y);
        }
        while (hitenemy.collider != null)
        {
        
            Destroy(hitenemy.collider.gameObject);
            hitenemy = Physics2D.Raycast(oldpos, Vector2.right, 10, LayerMask.GetMask("ghost"));

        }
        if(oldpos.x+10 <=transform.position.x)
        {
            chargedBool = false;
        }
        }
        

    }

    void stand()
    {
        standCollider.enabled = true;
        crouchCollider.enabled = false;
    }

    void crouch()
    {
        standCollider.enabled = false;
        crouchCollider.enabled = true;
        rb.AddForce(new Vector2(0, -4), ForceMode2D.Impulse);
        if(floorCol != null)
        {
            rb.AddForce(new Vector2(0,4), ForceMode2D.Impulse);
        }
    }

     void gameOver()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;

        Vector2 posbtn = replaybtn.transform.position;
        Vector2 postxt = replaybtn.transform.position;
        posbtn.x = 453; postxt.x = 453; posbtn.y = 309; postxt.y = 359;

        replaybtn.transform.position = posbtn;
        replaytxt.transform.position = postxt;
        replaybtn.gameObject.SetActive(true);
        replaytxt.gameObject.SetActive(true);
        gameOverBool = true;
    }

    private void OnCollisionEnter2D(Collision2D cls)
    {
        if (cls.gameObject.tag.Equals("Enemy")&& !chargedBool)
        {
            gameOver();
        }

    }
    public void replay()
    {
        SceneManager.LoadScene("oynanis");
    }
}
