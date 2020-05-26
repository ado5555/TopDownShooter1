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

    public float m_ShootDirectionX;
    public float m_ShootDirectionY;

    float CDMaxShoot = 0.75f;
    public float CurrentCDShoot;
    public bool shoot = false;

    public AudioClip gunshot;
    public AudioClip zombieyell;
    public AudioClip charactersteps;
    public AudioSource soundfx;

    private void Start()
    {
       
        
    }
    private void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        //animator.SetFloat("Horitzontal", Input.GetAxis("Horizontal")); TEST
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        if ((Input.GetAxis("Horizontal") != 0) && (Input.GetAxis("Vertical") != 0)) {
            soundfx.clip = charactersteps;
            soundfx.Play();

        }


        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

        Vector3 vertical = new Vector3(Input.GetAxis("Vertical"), 0.0f, 0.0f);
        transform.position = transform.position + vertical * 0.0f;

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * 20;

        transform.Translate(x, y, 0);

        if ((Input.GetAxis("Horizontal") == 0) && (Input.GetAxis("Vertical") == 0))
        {
            m_ShootDirectionX = 15.0f;
            m_ShootDirectionY = 0.0f;

        }
        else{ 
        
            if (Input.GetAxis("Horizontal") == 0)
            {
                m_ShootDirectionX = 0.0f;

            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                m_ShootDirectionX = 15.0f;

            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                m_ShootDirectionX = -15.0f;

            }

            if (Input.GetAxis("Vertical") == 0)
            {
                m_ShootDirectionY = 0.0f;

            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                m_ShootDirectionY = 15.0f;

            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                m_ShootDirectionY = -15.0f;

            }

        }

        if ((Input.GetKey("space")) && (shoot == true))
        {
            soundfx.clip = gunshot;
            soundfx.Play();
            GameObject bullet = Instantiate(bulletPrefab, bulletposition.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(m_ShootDirectionX, m_ShootDirectionY);
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


    


}
