using UnityEngine;
using System.Collections;

public class Avion : MonoBehaviour
{
    public Player player;
    public GameObject pass;
    
   
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

        if (col.tag == "Player" && player.piece >= 10)
        {
            pass.gameObject.SetActive(false);
            player.gameObject.SetActive(false);
            GetComponent<Animator>().Play("vole");
            Invoke("vic", 2);
            
            


        }

    }

    void vic()
    {
        transform.parent.gameObject.AddComponent<youwon>();
    }

}