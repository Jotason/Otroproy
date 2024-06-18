using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public playerController pc;
    public playerController pc2;

    public Vector3 pos;

    public Transform position;
    // Update is called once per frame

    void Start()
    {
        pos = this.transform.position;
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if(pc.enabled == true){



            pc.changePosition(pos);
            Debug.Log("Spawn 1 cambiado");
        }
        else
        {
            pc2.changePosition(pos);
        }

    }
}
