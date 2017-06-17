using UnityEngine;

/// <summary>
/// Projectile behavior
/// </summary>
public class ShotScript : MonoBehaviour
{
    public Player player;
    
    

    void Start()
    {
        // 2 - Limited time to live to avoid any leak
        Destroy(gameObject, 20); // 20sec
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float h = Input.GetAxis("Horizontal");
        if (col.tag == "Player")
        {
            
            //player.gameObject.SetActive(false);
            
            gameObject.SetActive(false);
            

        }

    }
}
