using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diescript : MonoBehaviour
{
    playerController pc;
    playerController pc2;
    void Start()
    {
        pc = Object.FindFirstObjectByType<playerController>();
        pc2 = Object.FindFirstObjectByType<playerController>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (pc.enabled == true) {

                pc.resetPosition();
            } else{
                pc2.resetPosition();
            }
            
            
        }
    }
   
}
