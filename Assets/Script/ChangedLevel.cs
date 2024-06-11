using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangedLevel : MonoBehaviour
{
    private void OnTriggetEnter2D(Collider2D collision){
	
	if(collision.gameObject.tag == "Player"){

		SceneManager.LoadScene(1);

		}

	}


}
