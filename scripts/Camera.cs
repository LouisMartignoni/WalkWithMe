using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public Player player;
    public Avion avion;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (player.transform.position.x < 2)
            transform.position = new Vector3(2f, 0, -1);
        else if(player.transform.position.x > 239)
        {
            if (avion.transform.position.x > 244)
                transform.position = new Vector3(244, 0, -1);
            else
            {
                transform.position = new Vector3(avion.transform.position.x, 0, -1);
            }
        }
        else
        {
            transform.position = new Vector3(player.transform.position.x, 0, -1);
        }
    }
}
