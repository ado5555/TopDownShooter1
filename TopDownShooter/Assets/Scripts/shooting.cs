using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {


    private GameManager m_GameManager;
    public float m_Speed;
   
    // Use this for initialization
    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position += Vector3.up * m_Speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cars"))
        {
            m_GameManager.m_score += 10;
            Destroy(collision.gameObject);
            this.gameObject.SetActive(false);

        }
    }
}
