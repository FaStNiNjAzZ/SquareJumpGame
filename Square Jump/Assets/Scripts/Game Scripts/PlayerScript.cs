using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float jumpPower = 10.0f;
    Rigidbody2D myRigidbody;
    bool isGrounded = false;
    float posX = 0.0f;
    bool isGameOver = false;
    public float scrollSpeed = 5.0f;
    SideScrollingPlayer mySideScrollingPlayer;
    public FillBar fillBar;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = transform.GetComponent<Rigidbody2D>();
        posX = transform.position.x;
        mySideScrollingPlayer = GameObject.FindObjectOfType<SideScrollingPlayer>();
        fillBar = GameObject.FindObjectOfType<FillBar>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey (KeyCode.Space) && isGrounded )//&& !isGameOver)
        {
            myRigidbody.AddForce(Vector3.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 20.0f));
        }
        if (Input.GetKey(KeyCode.Mouse0) && isGrounded)//&& !isGameOver)
        {
            myRigidbody.AddForce(Vector3.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 20.0f));
        }
        if (Input.GetKey(KeyCode.UpArrow) && isGrounded)//&& !isGameOver)
        {
            myRigidbody.AddForce(Vector3.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 20.0f));
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            myRigidbody.AddForce(Vector3.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 5.0f));
        }

        //Rigidbody2D player = GetComponent<Rigidbody2D>();
        //Vector2 vel = player.velocity;
        //if (vel.magnitude == 0)
        //{
        //  GameOver();
        //}
    }


    void Update()
    {

    }

    void GameOver()
    {
        isGameOver = true;
        mySideScrollingPlayer.GameOver();
    }

    void EndLevel1()
    {
        isGameOver = true;
        mySideScrollingPlayer.EndLevel1();
        fillBar.Level1Completed();
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
        if (other.collider.tag == "KillTrigger")
        {
            GameOver();
            Debug.Log("Gamer Over");
        }
        if (other.collider.tag == "End Level Trigger")
        {
            
            EndLevel1();
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }


    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}
