using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GettingDamage(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
        CheckHealth();
    }

    void CheckHealth()
    {
        if (curHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
