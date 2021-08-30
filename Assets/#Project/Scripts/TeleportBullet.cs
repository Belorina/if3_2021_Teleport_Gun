using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportBullet : MonoBehaviour
{
    public GameObject player;       // en public pourt que la variabl sois utilisable dans une autre classe 

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Bounce"))
        {
            Destroy(gameObject);    // gameobject en miniscule = donne gameobject au quelle apartien le script 

        }

        if (collision.collider.CompareTag("Teleport"))
        {
            player.transform.position = collision.GetContact(0).point;
        }
    }

}
