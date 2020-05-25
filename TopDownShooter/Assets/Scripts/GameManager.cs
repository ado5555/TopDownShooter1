using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    private static GameManager instance;

    public static GameManager GetInstance()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }
        return instance;
    }



    // Use this for initialization

    public Text m_TextPuntuacio;
    public Text m_TextVidas;
    public Text m_TextBullets;
    public GameObject m_GameRestart;
    public GameObject m_GameOverPanel;


    [HideInInspector] public float m_score;
    public int m_vidas = 5;
    public int m_balasmax = 30;
    public int m_balasactual = 50;

    public AudioClip Soundtrack;
    

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {


       
        m_TextVidas.text = "Vidas" + m_vidas;
        m_TextBullets.text = "Bullets" + m_balasactual;


        if (m_vidas <= 0)
        {
            m_GameOverPanel.SetActive(true);
        }

    }

    public void RestartGame()
    {
        m_GameRestart.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
