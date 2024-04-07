using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    public int maxHealth, currentHealth;
    public Text playerHealthUIText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamagePlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
        if(currentHealth < 60)
        {
            playerHealthUIText.color = Color.yellow;
        }
        if(currentHealth < 30)
        {
            playerHealthUIText.color = Color.red;
        }
        playerHealthUIText.text = currentHealth.ToString();
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            // Game Over
            gameObject.SetActive(false);
        }
    }
}
