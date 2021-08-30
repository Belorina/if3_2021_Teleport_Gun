using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletOriginTransform;     // top do: try with game object instead 

    public float bulletSpeed = 10f;

    public GameObject playerReference;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletOriginTransform.position, bulletOriginTransform.rotation);
        Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = bulletOriginTransform.forward * bulletSpeed; 

        TeleportBullet tpBullet = newBullet.GetComponent<TeleportBullet>();              // creation variable qui contiens teleport bullet de newbullet 
        tpBullet.player = playerReference;

    }
}
