using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour {
    private GameManager m_GameManager;
    // Use this for initialization
    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
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

