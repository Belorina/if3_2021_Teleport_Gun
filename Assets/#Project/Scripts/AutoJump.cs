using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJump : MonoBehaviour
{
    // variables 
    Rigidbody rb;
    public Vector3 verticalForce;
    public Vector3 additionalForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // chercher rigidbody et la metre dans rb
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity == Vector3.zero){       // velocity = vitesse 
            rb.AddForce(verticalForce);
            verticalForce += additionalForce;
        }

        // si la velicity de rb est egale à Vector3.zero
        //  alors: lui donner une force vers le haut -  rb.AddForce(Vector3) (la vertical)
        //      augementer la verticalForce de additionalForce pour la prochaine fois 

    }
}
