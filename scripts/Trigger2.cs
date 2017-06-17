using UnityEngine;
using System.Collections;

public class Trigger2 : MonoBehaviour
{

    public Player player;
    public AudioClip swim_audio;
    //


    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "Player" && h != -1)
        {
            player.GetComponent<Animator>().Play("Walk");
            player.nage = false;

        }
        else if (col.tag == "Player" && h != 1)
        {
            player.GetComponent<Animator>().Play("coule");
            player.nage = true;

        }
    }


    // Update is called once per frame
    void Update()
    {

    }
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
