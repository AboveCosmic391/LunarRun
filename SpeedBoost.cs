using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
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
            Debug.Log("Player hit the speed boost");
            PlayerMovement playerMovement = other.gameObject.GetComponent<PlayerMovement>();
            playerMovement.moveSpeed = 40f;
            StartCoroutine(RemoveSpeedBoost(playerMovement));
            Destroy(gameObject);
        }
    }

    IEnumerator RemoveSpeedBoost(PlayerMovement playerMovement)
    {
        yield return new WaitForSeconds(3);
        playerMovement.moveSpeed = 20f;
    }
}
