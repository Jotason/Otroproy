using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public AudioSource music;
    public GameObject omusic;
    // Start is called before the first frame update
    void Start()
    {
        music = omusic.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
