using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackyPacky : MonoBehaviour
{
    public List<GameObject> inventory = new List<GameObject>();

    int count = 0; 
   void Update()
    {
        //Button assinged to switching weapons
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(count < inventory.Count - 1)
            {
                count++;
                Switching();
            }
            else
            {
                count = 0;
                Switching(); 
            }
        }
    }
    //This switches between the weapons 
    public void Switching()
    {
        inventory[0].SetActive(false);
        inventory[1].SetActive(false);
        inventory[2].SetActive(false);
        inventory[count].SetActive(true);
    }

    


}
