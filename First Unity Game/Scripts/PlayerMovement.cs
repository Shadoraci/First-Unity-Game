using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour 
{
    public float Sensitivity = 20.0f;
    public float m_Speed = 0.0f;
    private Rigidbody m_Rigidbody;
    public GameObject Bullet;
    public Transform Shotspawn;
    Quaternion m_Rotation = Quaternion.identity;
    Vector3 m_Movement;
    public GameObject GUNS1;
    public GameObject GUNS2;
    public GameObject GUNS3;



    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //a bunch of mouse movement stuff
        if (Input.GetMouseButtonDown(0))
        {
            print("The Left mouse button was pressed");
        }

        float mouseXvalue = Input.GetAxis("Mouse X");
        float mouseYvalue = Input.GetAxis("Mouse Y");

        if (mouseXvalue != 0)
        {
            print("Mouse X movement: " + mouseXvalue);
        }
        if (mouseYvalue != 0)
        {
            print("Mouse Y movement: " + mouseYvalue);
        }
        //shooting stuff
        if (Input.GetMouseButtonDown(0))
        {
            if (GUNS1.activeSelf)
            {
                GUNS1.GetComponent<Weapon>().Shoot();
            }
            if(GUNS2.activeSelf)
            {
                GUNS2.GetComponent<Weapon>().Shoot2();
            }
            if (GUNS3.activeSelf && Input.GetMouseButtonDown(0) == true)
            {
                GUNS3.GetComponent<Weapon>().Shoot3();
            }
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //input of mouse
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_Movement.Set(horizontal, 0f, vertical);

        Vector3 m_Input = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal");

        m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
        m_Movement.Normalize();
    }

}
