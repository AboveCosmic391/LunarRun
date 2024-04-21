using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit the speed boost");
            // PlayerMovement playerMovement = other.gameObject.GetComponent<PlayerMovement>();
            playerMovement.moveSpeed = 80f;
            // gameObject.SetActive(false);
            StartCoroutine(RemoveSpeedBoost());
            
            Debug.Log("Player speed is now: " + playerMovement.moveSpeed);
        }
    }

    IEnumerator RemoveSpeedBoost()
    {
        Debug.Log("Waited 3 seconds");
        Debug.Log("Slowing the player is being called in function");
        // gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        playerMovement.moveSpeed = 20f;
        Debug.Log("Removing speed boost: Player speed is now: " + playerMovement.moveSpeed);
        Destroy(gameObject);
    }
}
