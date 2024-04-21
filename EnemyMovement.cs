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
    public GameObject routeMark6; // Assign the sixth route mark
    public GameObject routeMark7; // Assign the seventh route mark
    public GameObject routeMark8; // Assign the eighth route mark
    public GameObject routeMark9; // Assign the ninth route mark
    public GameObject routeMark10; // Assign the tenth route mark
    public GameObject routeMark11; // Assign the eleventh route mark
    public GameObject routeMark12; // Assign the twelfth route mark
    public GameObject routeMark13; // Assign the thirteenth route mark
    public GameObject routeMark14; // Assign the fourteenth route mark

    [HideInInspector]
    public bool isMark1Complete = false;
    public bool isMark2Complete = false;
    public bool isMark3Complete = false;
    public bool isMark4Complete = false;
    public bool isMark5Complete = false;
    public bool isMark6Complete = false;
    public bool isMark7Complete = false;
    public bool isMark8Complete = false;
    public bool isMark9Complete = false;
    public bool isMark10Complete = false;
    public bool isMark11Complete = false;
    public bool isMark12Complete = false;
    public bool isMark13Complete = false;
    public bool isMark14Complete = false;

    // private string currentRouteMark;

    public Rigidbody enemyVehicle;


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
        else if(!isMark6Complete)
        {
            direction = (routeMark6.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark7Complete)
        {
            direction = (routeMark7.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark8Complete)
        {
            direction = (routeMark8.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark9Complete)
        {
            direction = (routeMark9.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark10Complete)
        {
            direction = (routeMark10.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark11Complete)
        {
            direction = (routeMark11.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark12Complete)
        {
            direction = (routeMark12.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark13Complete)
        {
            direction = (routeMark13.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else if(!isMark14Complete)
        {
            direction = (routeMark14.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
            Debug.Log("Route completed");
            enemyVehicle.velocity = Vector3.zero; // stop enemy vehicle
        }
        else
        {
            Debug.Log("Route completed");
        }
    }



}
