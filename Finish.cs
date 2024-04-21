using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player has reached the finish line");
            player = GameObject.Find("Player");
            // stop the player object's motion
            player.GetComponent<PlayerMovement>().moveSpeed = 0;

        }
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy has reached the finish line");
        }
    }
}
