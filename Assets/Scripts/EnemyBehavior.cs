using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    public Vector3 raycastOffset;
    public float minObstacleDistance;

    private Vector3 facing;
    public bool Patroller;
    public bool Flying;

    public GameObject pointA;
    public GameObject pointB;

    public AudioSource audioPlayer;
    public AudioClip sound;

    public bool x;
    public bool z;

    bool isColliding;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        if (z)
        {
            facing = this.gameObject.transform.forward;
        }
        else if (x)
        {
            facing = this.gameObject.transform.right;
        }
        audioPlayer.clip = sound;
    }

    // Update is called once per frame
    void Update()
    {

        if (Patroller)
        {
            Movement();

            if (Physics.Raycast(this.transform.position, facing, minObstacleDistance) ||
                Physics.Raycast(this.transform.position + new Vector3(0, 1, 0), facing, minObstacleDistance) ||
                Physics.Raycast(this.transform.position + new Vector3(0, -1, 0), facing, minObstacleDistance))
            //!Physics.Raycast(this.transform.position + raycastOffset, Vector3.down, 1
            {
                
                Flip();
            }
            
            if(audioPlayer.isPlaying == false)
            {
                audioPlayer.PlayDelayed(Random.Range(1, 3));
            }
        }

        if (Flying)
        {
            Movement();
        }


    }

    void Movement()
    {
        //Gets forward direction (z axis) and moves in that direction
        rb.AddForce(facing * speed, ForceMode.Force);
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //Stops from speeding up constantly and flying off map
        if (flatVel.magnitude > speed)
        {
            Vector3 limitedVel = flatVel.normalized * speed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    void Flip()
    {
        facing = facing * -1;

        /*Vector3 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Patroller)
        {
            Death.dead = true;
        }
        if (other.CompareTag("Edge"))
        {
            Flip();
        }
        if (other.CompareTag("AirEnemyTurn"))
        {
            rb.velocity = Vector3.zero;
            Flip();
            Debug.Log("Turn!");
        }
    }
}
 