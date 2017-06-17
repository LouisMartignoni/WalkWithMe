using UnityEngine;
using System.Collections;

public class triggerdacia : MonoBehaviour
{

    public Player player;
    public GameObject auto;
    public GameObject son;

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
            
            auto.gameObject.SetActive(true);
            son.gameObject.SetActive(true);
            son.active = true;

            



        }

    }


}
