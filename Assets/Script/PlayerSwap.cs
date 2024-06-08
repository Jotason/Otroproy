using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwap : MonoBehaviour
{
    public playerController playerController;
    public playerController playerController2;
    private bool playerActive = false;
    // Start is called before the first frame update
    void Start()
    {
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
            playerActive = false;
        }
        else
        {
            playerController.enabled = true;
            playerController2.enabled = false;
            playerController.rb.bodyType = RigidbodyType2D.Dynamic;
            playerController2.rb.bodyType = RigidbodyType2D.Kinematic;
            playerActive = true;
        }
    }
}
