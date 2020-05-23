using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{


    public float m_Speed;
    private GameManager m_GameManager;
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.down * m_Speed * Time.deltaTime;
    }
    private void OnColliderEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ambulancia"))
        {
            Destroy(collision.collider.gameObject);
            Destroy(this.gameObject);
        }

        if (collision.collider.CompareTag("Shield2"))
        {
            Destroy(collision.collider.gameObject);
            Destroy(this.gameObject);
        }

    }
}
