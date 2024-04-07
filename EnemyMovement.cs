using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float moveSpeed = 40f; // Adjust the speed as needed

    public GameObject routeMark1; // Assign the first route mark
    public GameObject routeMark2; // Assign the second route mark
    public GameObject routeMark3; // Assign the third route mark
    public GameObject routeMark4; // Assign the fourth route mark
    public GameObject routeMark5; // Assign the fifth route mark

    [HideInInspector]
    public bool isMark1Complete = false;
    public bool isMark2Complete = false;
    public bool isMark3Complete = false;
    public bool isMark4Complete = false;
    public bool isMark5Complete = false;

    // private string currentRouteMark;


    // Start is called before the first frame update
    void Start()
    {
        // currentRouteMark = "one";
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }

    void MoveForward()
    {
        Vector3 direction;
        // switch (currentRouteMark)
        // {
        //     case "one":
        //         direction = (routeMark1.transform.position - transform.position).normalized;
        //         transform.position += direction * moveSpeed * Time.deltaTime;
        //         currentRouteMark = "two";
        //         break;
        //     case "two":
        //         direction = (routeMark2.transform.position - transform.position).normalized;
        //         transform.position += direction * moveSpeed * Time.deltaTime;
        //         currentRouteMark = "three";
        //         break;
        //     default:
        //         Debug.Log("Route completed");
        //         break;

        // }
        // Move the enemy vehicle forward along its local z-axis
        if(!isMark1Complete)
        {
            direction = (routeMark1.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark2Complete)
        {
            direction = (routeMark2.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark3Complete)
        {
            direction = (routeMark3.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark4Complete)
        {
            direction = (routeMark4.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark5Complete)
        {
            direction = (routeMark5.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else
        {
            Debug.Log("Route completed");
        }
        // transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("Collision detected : " + other.gameObject.tag);
    //     if(other.gameObject.tag == "Enemy")
    //     {
    //         isMark1Complete = true;
    //     }
    // }

}
