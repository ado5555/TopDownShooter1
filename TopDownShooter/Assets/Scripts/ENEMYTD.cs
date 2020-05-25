using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYTD : MonoBehaviour
{

    public GameObject m_InitialPosition;
    GameObject m_Character;
    bool touch = false;

    public int m_speed = 2;
    public Vector3 Vectordirector;


    // Start is called before the first frame update
    void Start()
    {
        m_Character = GameObject.FindGameObjectWithTag("Character");
    }

    // Update is called once per frame
    void Update()
    {
        if (touch == true)
        {
            m_Character.transform.position = m_InitialPosition.transform.position; //Initial position es un empty game object solo para poder usar la posicion esa para hacer tp una vez mueres.

            touch = false;

        }

        transform.position += Vectordirector * Time.deltaTime * m_speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("Limit1")))//toca con derecha
        {
            Vectordirector = Vector3.down;
            this.transform.Rotate(0, 180, 0);

        }
        else if ((collision.CompareTag("Limit2")))//toca con izquierda
        {
            Vectordirector = Vector3.up;
            this.transform.Rotate(0, 180, 0);

        }
        else if (collision.CompareTag("Character")) //enemy toca con character
        {
            GameManager.GetInstance().m_vidas += -1;
            touch = true;

        }


    }

}
