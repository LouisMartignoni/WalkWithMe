using UnityEngine;
using System.Collections;

public class TriggerSI28 : MonoBehaviour
{

    public Serge serge;

    //


    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "Player")
        {
            serge.gameObject.SetActive(true);


        }
     
    }


    // Update is called once per frame
    void Update()
    {

    }

}
