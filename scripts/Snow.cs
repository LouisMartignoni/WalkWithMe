using UnityEngine;
using System.Collections;

public class Snow : MonoBehaviour
{
    public GameObject target;


    void Start()
    {
        InvokeRepeating("SpawnObject", 1, 1);
    }

    void SpawnObject()
    {
        float x = Random.Range(65, 150);
        Instantiate(target, new Vector2(x, 3), Quaternion.identity);
      /*  float y = Random.Range(65, 150);
        Instantiate(target, new Vector2(y, 3), Quaternion.identity);
        float w = Random.Range(65, 150);
        Instantiate(target, new Vector2(w, 3), Quaternion.identity);
        float z = Random.Range(65, 150);
        Instantiate(target, new Vector2(z, 3), Quaternion.identity);*/
    }
}