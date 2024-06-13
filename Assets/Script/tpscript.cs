using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class tpscript : MonoBehaviour
{

    public playerController pc;
    public playerController pc2;
    public tpobject2script tp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (pc.enabled == true) {
            pc.transform.position = tp.transform.position;
        }
        if (pc2.enabled == true)
        {
            pc2.transform.position = tp.transform.position;
        }



    }

}
