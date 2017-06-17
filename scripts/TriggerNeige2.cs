using UnityEngine;
using System.Collections;

public class TriggerNeige2 : MonoBehaviour {

    public Player player;


    // Use this for initialization
    void Start () {
	
	}


    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "Player" && h != -1)
        {
            player.GetComponent<Animator>().Play("Walk");
            player.neige = false;

        }
        else if (col.tag == "Player" && h != 1)
        {
            player.GetComponent<Animator>().Play("guitare");
            player.neige = true;

        }
    }


    // Update is called once per frame
    void Update () {
	
	}
}
