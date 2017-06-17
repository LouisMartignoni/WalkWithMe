using UnityEngine;
using System.Collections;

public class Piece : MonoBehaviour {

    public Player player;
    public AudioClip Audio_piece;
    // Use this for initialization
    void Start () {
       
	}


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            gameObject.SetActive(false);
            player.piece = player.piece + 1;
            MakeSound(Audio_piece);
        }

    }


    // Update is called once per frame
    void Update () {
	
	}

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
