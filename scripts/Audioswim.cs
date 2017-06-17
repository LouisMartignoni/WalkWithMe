using UnityEngine;
using System.Collections;

public class Audioswim : MonoBehaviour {

    public Player player;

	// Use this for initialization
	void Awake () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (!player.nage)
            gameObject.SetActive(false);
	}
}
