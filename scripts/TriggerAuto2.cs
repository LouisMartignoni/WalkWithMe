using UnityEngine;
using System.Collections;

public class TriggerAuto2 : MonoBehaviour
{

    public Player player;
    public Auto2 auto;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "Player")
        {
            player.conduite = false;
            auto.gameObject.SetActive(true);
            player.GetComponent<Animator>().Play("Immobile");
           


        }

    }


}
