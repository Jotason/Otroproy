using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{

    public playerController pc;
    public playerController pc2;
    public GameObject pauseButton;
    public GameObject menuButton;
    public bool gamePause = false;

    
    // Start is called before the first frame update

    void Start()
    {


        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {

            if (gamePause) {
                Resume();
                pc.rb.bodyType = RigidbodyType2D.Dynamic;
                pc2.rb.bodyType = RigidbodyType2D.Dynamic;
                
            }
            else
            {
                Paus();
                pc.rb.bodyType= RigidbodyType2D.Static;
                pc2.rb.bodyType = RigidbodyType2D.Static;
            }
        }
    }


    public void Paus() { 
    
        gamePause = true;
        Time.timeScale = 1f;
        pauseButton.SetActive(false);
        menuButton.SetActive(true);
        pc.rb.bodyType = RigidbodyType2D.Static;
        pc2.rb.bodyType = RigidbodyType2D.Static;
    }

    public void Resume()
    {

        gamePause = false;
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        menuButton.SetActive(false);
        pc.rb.bodyType = RigidbodyType2D.Dynamic;
        pc2.rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void Restart()
    {

        gamePause = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {

        SceneManager.LoadScene("mainmenu");
        Application.Quit();
    }

}
