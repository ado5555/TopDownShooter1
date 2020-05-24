using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMIENTO2 : MonoBehaviour
{

    public float m_speed = 3f;
    public bool facingRight = true;
    public bool facingLeft = false;
    public bool facingUp = false;
    public bool facingDown = false;


    //this.transform.Rotate(0, 180, 0);

    //this.transform.position += this.transform.right * Time.deltaTime * m_speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Moviment 
        if (Input.GetAxis("Horizontal") > 0)//Right
        {
            this.transform.position += this.transform.right * Time.deltaTime * m_speed;



        }
        else if (Input.GetAxis("Horizontal") < 0)//Left
        {
            this.transform.position += -this.transform.right * Time.deltaTime * m_speed;



        }
        else if (Input.GetAxis("Vertical") > 0)//Up
        {
            this.transform.position += this.transform.up * Time.deltaTime * m_speed;

        

        }
        else if (Input.GetAxis("Vertical") < 0)//Right
        {
            this.transform.position += -this.transform.up * Time.deltaTime * m_speed;



        }

    }
}