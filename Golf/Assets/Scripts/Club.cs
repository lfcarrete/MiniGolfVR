using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour
{

    public Transform aimTarget; // the target where we aim to land the ball
    float speed = 5.0f; // move speed
    //float force = 13; // ball impact force
    Vector3 aimTargetInitialPosition; // initial position of the aiming gameObject which is the center of the opposite court

    void Start()
    {
        aimTargetInitialPosition = aimTarget.position; // initialise the aim position to the center( where we placed it in the editor )
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) // if we collide with the ball 
        {
            Vector3 dir = aimTarget.position - transform.position; // get the direction to where we want to send the ball
            //add force to the ball plus some upward force according to the shot being played
            
            Vector3 velocidade = dir.normalized * speed;

            other.GetComponent<Rigidbody>().velocity =  velocidade;

            print(velocidade);
            Debug.DrawRay(transform.position, transform.position+velocidade, Color.red);

        }
    }
}
