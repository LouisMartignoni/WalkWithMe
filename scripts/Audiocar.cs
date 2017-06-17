using UnityEngine;
using System.Collections;

public class Audiocar : MonoBehaviour
{

    public bool active;

    void Awake()
    {
        gameObject.SetActive(false);
        active = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (active)
            Destroy(gameObject, 20);
    }
}