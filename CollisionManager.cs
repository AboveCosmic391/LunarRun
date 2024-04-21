using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    public GameObject enemy;
    public GameObject routeClear1;
    // Start is called before the first frame update
    void Start()
    {
        routeClear1 = GameObject.Find("RouteClear1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected: names: " + this.gameObject.name + " collided with " + other.gameObject.name);
        Debug.Log("Tags: " + this.gameObject.tag + " collided with " + other.gameObject.tag);
        // Debug.Log("Is Mark 1 Complete: " + enemy.GetComponent<EnemyMovement>().isMark1Complete);
        // Debug.Log("Is Mark 2 Complete: " + enemy.GetComponent<EnemyMovement>().isMark2Complete);
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear1")
        {
            Debug.Log("Enemy collided with the RouteClear1 marker");
            enemy.GetComponent<EnemyMovement>().isMark1Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear2")
        {
            Debug.Log("Enemy collided with the RouteClear2 marker");
            enemy.GetComponent<EnemyMovement>().isMark2Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear3")
        {
            Debug.Log("Enemy collided with the RouteClear3 marker");
            enemy.GetComponent<EnemyMovement>().isMark3Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear4")
        {
            Debug.Log("Enemy collided with the RouteClear4 marker");
            enemy.GetComponent<EnemyMovement>().isMark4Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear5")
        {
            Debug.Log("Enemy collided with the RouteClear5 marker");
            enemy.GetComponent<EnemyMovement>().isMark5Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear6")
        {
            Debug.Log("Enemy collided with the RouteClear6 marker");
            enemy.GetComponent<EnemyMovement>().isMark6Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear7")
        {
            Debug.Log("Enemy collided with the RouteClear7 marker");
            enemy.GetComponent<EnemyMovement>().isMark7Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear8")
        {
            Debug.Log("Enemy collided with the RouteClear8 marker");
            enemy.GetComponent<EnemyMovement>().isMark8Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear9")
        {
            Debug.Log("Enemy collided with the RouteClear9 marker");
            enemy.GetComponent<EnemyMovement>().isMark9Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear10")
        {
            Debug.Log("Enemy collided with the RouteClear10 marker");
            enemy.GetComponent<EnemyMovement>().isMark10Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear11")
        {
            Debug.Log("Enemy collided with the RouteClear11 marker");
            enemy.GetComponent<EnemyMovement>().isMark11Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear12")
        {
            Debug.Log("Enemy collided with the RouteClear12 marker");
            enemy.GetComponent<EnemyMovement>().isMark12Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear13")
        {
            Debug.Log("Enemy collided with the RouteClear13 marker");
            enemy.GetComponent<EnemyMovement>().isMark13Complete = true;
        }
        if(other.gameObject.tag == "Enemy" && this.gameObject.name == "RouteClear14")
        {
            Debug.Log("Enemy collided with the RouteClear14 marker");
            enemy.GetComponent<EnemyMovement>().isMark14Complete = true;
        }

    }
}
