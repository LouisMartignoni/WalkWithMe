using UnityEngine;
using System.Collections;

public class Player: MonoBehaviour
{

    [HideInInspector]
    public bool facingRight = true;
    [HideInInspector]
    public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;
    public bool neige = false;
    public bool nage = false;
    public bool conduite = false;
    public int piece;
    private float plafond = 3;
    public ShotScript shotPrefab;

    public AudioClip jmpaudio;
    public GameObject audioswim;
    



    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;



    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }


    // Utilisez cette fonction pour l'initialisation
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Awake()
    {
        //gameObject.SetActive(false);
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        piece = 0;
        

    }

   

    // Update est appelee une fois par frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetButtonDown("Jump"))// && grounded)
        {
            jump = true;
        }

        
        
    }

    void FixedUpdate()
    {

        

        float h = Input.GetAxis("Horizontal");

        if (piece == 10)
        {
            
        }
        /* if (nage)
             MakeSound(swim_audio);*/

        // anim.SetFloat("Speed", Mathf.Abs(h));
        if (nage)
            audioswim.SetActive(true);
        if (h != 0 && !nage && !neige && !conduite)
            GetComponent<Animator>().Play("Walk");
        if (h != 0 && !nage && neige && !conduite)
            GetComponent<Animator>().Play("Walk2");
        if (h == 0 && !nage && !neige && !conduite)
            GetComponent<Animator>().Play("Immobile");
        if (h == 0 && !nage && neige && !conduite)
            GetComponent<Animator>().Play("guitare");
        if (h != 0 && nage && !neige && !conduite)
            GetComponent<Animator>().Play("Natation");
        if (h == 0 && nage && !neige && !conduite)
            GetComponent<Animator>().Play("coule");
        if (conduite)
        {
            GetComponent<Animator>().Play("Auto");
            jump = false;
        }
       


        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (transform.position.x < -4)
            transform.position = new Vector3(-4, transform.position.y, transform.position.z);
        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
        if (transform.position.y > plafond)
            transform.position = new Vector3(transform.position.x,plafond,transform.position.z);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump && transform.position.y < plafond-1 && !nage)
        {
            anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
            MakeSound(jmpaudio);
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "bullet" )
        { 
            
            transform.parent.gameObject.AddComponent<GameOverScript>();
            gameObject.SetActive(false);
        }

    }

 }





