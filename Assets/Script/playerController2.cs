using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController2 : MonoBehaviour
{
    playerController2 pc2;
    public float speed2;
    public Rigidbody2D rb2;
    public float axisHorizontal2;
    public float jumpForce2;
    Vector3 iniPo2;
    public float distanceGround2;
    public bool isGround2;

    private Transform foot2;
    public LayerMask groundMask2;


    public GameObject oDeadPlayer2;
    public AudioSource aSDeadPlayer2;

    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        iniPo2 = transform.position;
        aSDeadPlayer2 = oDeadPlayer2.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        axisHorizontal2 = Input.GetAxis("Horizontal");

        



        Debug.DrawRay(transform.position, Vector2.down * distanceGround2, Color.red);

        if (Physics2D.Raycast(transform.position, Vector2.down, distanceGround2, groundMask2))
        {
            isGround2 = true;
        }
        else
        {
            isGround2 = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && isGround2 == true)
        {
            rb2.AddForce(Vector2.up * jumpForce2);
        }
    }

    private void FixedUpdate()
    {
            rb2.velocity = new Vector2(axisHorizontal2 * speed2, rb2.velocity.y);
        
    }

    public void resetPosition2()
    {
        transform.position = iniPo2;
        aSDeadPlayer2.Play();
    }
}
