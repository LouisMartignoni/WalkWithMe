﻿using UnityEngine;
using System.Collections;

public class TriggerAuto : MonoBehaviour {

    public Player player;
   // public Gameobject auto;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "Player" )
        {
           // player.GetComponent<Animator>().Play("Auto");
            player.conduite = true;

            

        }
       
    }


}
