using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public GameObject pauseMenu;

    public static bool isPaused;


    void Start() {
        pauseMenu.SetAction(false);    

    }

    void Update() {
        if(input.GetKeyDown(KeyCode.Escape)){
            if(isPaused)
            {
                ResumeGame();
            }else{
                PauseGame();
            }
        }
    }

    public void PauseGame(){

        pauseMenu.SetAction(true);
        Time.timeScale= 0f;
        isPaused = true;
    }


    public void ResumeGame(){

        pauseMenu.SetAction(false);
        Time.timeScale= 1f;
        isPaused = false;
    }

}
