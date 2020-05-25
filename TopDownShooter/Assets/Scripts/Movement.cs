using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public int position;
    public GameObject bulletPrefab;
    public GameObject bulletposition;
    public Animator animator;
    

    float CDMaxShoot = 1.5f;
    public float CurrentCDShoot;
    public bool shoot = false;


    private void Start()
    {
       // m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
    }
    private void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        //animator.SetFloat("Horitzontal", Input.GetAxis("Horizontal")); TEST
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);




        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

        Vector3 vertical = new Vector3(Input.GetAxis("Vertical"), 0.0f, 0.0f);
        transform.position = transform.position + vertical * 0.0f;

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * 20;

        transform.Translate(x, y, 0);

        if ((Input.GetKey("space")) && (shoot == true))
        {
            
            GameObject bullet = Instantiate(bulletPrefab, bulletposition.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(15.0f, 0.0f);
            shoot = false;
            CurrentCDShoot = 0;
                       
        }

        if (CurrentCDShoot < CDMaxShoot)
        {
            CurrentCDShoot += Time.deltaTime;

        }

        if (CurrentCDShoot >= CDMaxShoot)
        {
            shoot = true;

        }


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
