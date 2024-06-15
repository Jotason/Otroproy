using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangedLevel : MonoBehaviour
{

	public int sceneChange;
    private void OnTriggerEnter2D(Collider2D collision){
	
	if(collision.tag == "Player"){

			Debug.Log("entro");

		SceneManager.LoadScene(sceneChange);

		}

	}


}
