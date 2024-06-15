using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemaFocus : MonoBehaviour
{
    public playerController pc1;
    public playerController pc2;

    public Transform pc1t;

    public Transform pc2t;

    private CinemachineVirtualCamera cinemachineVirtualCamera;
    public ICinemachineCamera Camera;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reenfoque() {

        cinemachineVirtualCamera = gameObject.GetComponent<CinemachineVirtualCamera>();
        cinemachineVirtualCamera.Follow = pc2t;
    }
}
