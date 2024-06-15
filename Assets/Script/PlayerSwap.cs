using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerSwap : MonoBehaviour
{
    public playerController playerController;
    public playerController playerController2;

    public GameObject camara1;
    public GameObject camara2;


    private CinemachineVirtualCamera cinemachineVirtualCamera;

    private bool playerActive = false;
    // Start is called before the first frame update
    void Start()
    {
        camara1.SetActive(true);
        camara2.SetActive(false);

        playerController.enabled = false;
        playerController2.enabled = true;

        playerController.enabled = true;
        playerController2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            switchPlayer();
        }

    }

    public void switchPlayer()
    {

        if (playerActive)
        {
            playerController.enabled = false;
            playerController2.enabled = true;
            playerController.rb.bodyType = RigidbodyType2D.Kinematic;
            playerController2.rb.bodyType = RigidbodyType2D.Dynamic;
            camara1.SetActive(false);
            camara2.SetActive(true);
            playerActive = false;
        }
        else
        {
            playerController.enabled = true;
            playerController2.enabled = false;
            playerController.rb.bodyType = RigidbodyType2D.Dynamic;
            playerController2.rb.bodyType = RigidbodyType2D.Kinematic;

            camara1.SetActive(true);
            camara2.SetActive(false);
            playerActive = true;
        }
    }
}
