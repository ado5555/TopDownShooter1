using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{

    public int m_speed = 2;
    public Vector3 Vectordirector;



    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(0, 180, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vectordirector * Time.deltaTime * m_speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("Limit1")))//toca con derecha
        {
            Vectordirector = Vector3.left;
            this.transform.Rotate(0, 180, 0);

        }
        else if ((collision.CompareTag("Limit2")))//toca con izquierda
        {
            Vectordirector = Vector3.right;
            this.transform.Rotate(0, 180, 0);

        }
       

    }

}
