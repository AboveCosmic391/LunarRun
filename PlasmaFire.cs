using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaFire : MonoBehaviour
{

    PlayerHealth playerHealth;
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
            Debug.Log("Enemy hit by plasma fire");
            playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            playerHealth.DamagePlayer(10);
            // Destroy(other.gameObject);
        }
    }
}
