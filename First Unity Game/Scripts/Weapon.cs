using System;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	//Makes the attribute viewable in insepctor
	public float fireRate = 10f;
	public GameObject Bullet;
    public GameObject BIGGERBULLET; 
	public Transform Shotspawn, Shotspawn2, Shotspawn3, Shotspawn4, Shotspawn5;
  
    public List<Transform> shootPosition = new List<Transform>();
    public List<Transform> Automatic = new List<Transform>(); 

    public void Shoot()//basic weapon
	{
		GameObject FireBullet = Instantiate(Bullet, Shotspawn.position, Shotspawn.rotation);
        FireBullet.GetComponent<Rigidbody>().velocity = (transform.forward * fireRate);
        Destroy(FireBullet, 1f);
        
    }
    public void Shoot2()//Scattergun
    {
        //Summons 5 bullets at teh same time to imitate shotgun
         GameObject obj = Instantiate(Bullet, Shotspawn.position, Shotspawn.rotation);
         GameObject obj2 = Instantiate(Bullet, Shotspawn2.position, Shotspawn2.rotation);
         GameObject obj3 = Instantiate(Bullet, Shotspawn3.position, Shotspawn3.rotation);
         GameObject obj4 = Instantiate(Bullet, Shotspawn4.position, Shotspawn4.rotation);
         GameObject obj5 = Instantiate(Bullet, Shotspawn5.position, Shotspawn5.rotation);
         obj.GetComponent<Rigidbody>().velocity = (transform.forward * fireRate);
         Destroy(obj, 1f);
         Destroy(obj2, 1f);
         Destroy(obj3, 1f);
         Destroy(obj4, 1f);
         Destroy(obj5, 1f);

        //instantiates all bullets in list
        /*
        for (int n = 0; n < shootPosition.Count; n++)
        {
            //spawning bullet and settings its velocity
            GameObject obj = Instantiate(Bullet, Shotspawn.position, Shotspawn.rotation);
            //obj.transform.eulerAngles = transform.eulerAngles;
            obj.GetComponent<Rigidbody>().velocity = (transform.forward * fireRate);
            Destroy(obj, 1f);
        }
        */
    }
    public void Shoot3()//Cannon
    {

        
        GameObject FireBullet = Instantiate(BIGGERBULLET, Shotspawn.position, Shotspawn.rotation);
        Destroy(FireBullet, 1f);


    }
    void Update()
    {
        
    }
}
