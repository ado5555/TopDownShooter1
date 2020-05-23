using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public int position;




    private void Start()
    {
       // m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
    }
    private void Update()
    {

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

        Vector3 vertical = new Vector3(Input.GetAxis("Vertical"), 0.0f, 0.0f);
        transform.position = transform.position + vertical * 0.0f;

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * 20;

        transform.Translate(x, y, 0);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       // if (collision.CompareTag("PowerMedkit"))
        {
          //  Destroy(collision.gameObject);
            //m_GameManager.m_vidas += 1;
            //m_GameManager.VidasAmbulancia();

        }
    }
    


}
