using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    private float Speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 15;
        GetComponent<Rigidbody>().velocity = transform.forward * Speed;

    }

    // Update is called once per frame
    void Update()
    {

    }
    //killing enemies
    void OnCollisionEnter(Collision Contact)
    {
        if (Contact.gameObject.tag == "Enemy")
        {
            Destroy(Contact.gameObject);
            Destroy(gameObject);
        }
        else
        {
            //Destroy(gameObject);  This code breaks as if it doesn't contact anything immediately, it destroys the entire object.
            //Moved destruction to Lemon's file. This code also doesn't make much sense. 
        }
    }
}
