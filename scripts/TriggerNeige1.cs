using UnityEngine;
using System.Collections;

public class TriggerNeige1 : MonoBehaviour {

    public Player player;

    // Use this for initialization
    void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "Player" && h != -1)
        {
            player.GetComponent<Animator>().Play("Walk2");
            player.neige = true;

        }
        else if (col.tag == "Player" && h != 1)
        { 
            player.GetComponent<Animator>().Play("Walk");
            player.neige = false;
        }
    }


    // Update is called once per frame
    void Update () {
	
	}
}
