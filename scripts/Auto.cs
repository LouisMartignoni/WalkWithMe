using UnityEngine;
using System.Collections;

public class Auto : MonoBehaviour {

    public Player player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (player.conduite == true)
            gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            gameObject.SetActive(false);
            player.conduite = true;
            player.GetComponent<Animator>().Play("Auto");
        }

    }
}
