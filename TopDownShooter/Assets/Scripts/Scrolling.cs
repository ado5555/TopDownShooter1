using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {
     public float m_Speed;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += Vector3.down * m_Speed * Time.deltaTime;
	}
}
