using UnityEngine;
using System.Collections;

public class baby : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D rb2d;
    public Player player;


    // Utilisez cette fonction pour l'initialisation
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update est appelee une fois par frame
   

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (Input.GetMouseButtonDown(0))
        {
            
            gameObject.SetActive(false);
            player.gameObject.SetActive(true);

        }

      
    }
    
}