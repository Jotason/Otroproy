using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenema : MonoBehaviour
{
    // Start is called before the first frame update
    public void Playing()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        //SceneManager.LoadScene("Salida");
        Application.Quit();
    }

    public void Main()
    {

        SceneManager.LoadScene(0);
    }

    //public void Retor()
    //{ 
    //SceneManager.LoadScene("Interface");
    //}
}
