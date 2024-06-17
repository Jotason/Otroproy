using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValiTwo : MonoBehaviour
{



    public int sceneChange;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Finish")
        {

            Debug.Log("entro");

            SceneManager.LoadScene(sceneChange);

        }

    }
}
