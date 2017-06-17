using UnityEngine;
using System.Collections;

public class Trigger1 : MonoBehaviour {

    public Player player;
    
    //


    // Use this for initialization
    void Start () {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "Player" && h != -1)
        { 
            player.GetComponent<Animator>().Play("coule");
            player.nage = true;
            

        }
        else if (col.tag == "Player" && h != 1)
        {
            player.GetComponent<Animator>().Play("Walk");
            player.nage = false;
            
        }
    }


    // Update is called once per frame
    void Update ()
    {
	    
	}
    
}
