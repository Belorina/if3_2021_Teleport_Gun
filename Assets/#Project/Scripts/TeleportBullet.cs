using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportBullet : MonoBehaviour
{
    public GameObject player;       // en public pourt que la variabl sois utilisable dans une autre classe 

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("BOOM");
        Destroy(gameObject);    // gameobject en miniscule = donne gameobject au quelle apartien le script 
        
        Debug.Log("Point de contact: " + collision.GetContact(0).point);     // GetContact sans S car on prends que le premier // .point car on veux que le point
        player.transform.position = collision.GetContact(0).point;
    }
  
}
