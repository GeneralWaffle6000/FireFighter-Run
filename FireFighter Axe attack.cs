using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackpos;
    public LayerMask WhatIsEnemies;
    public float attackRange;
    public int damage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwAttack <= 0)
        {//then you can attack
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackpos.position, attackRange, WhatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                    enemiesToDamage[i].GetComponent<HostileRocks>().TakeDamage(damage);
                {

                }
            }
            timeBtwAttack = startTimeBtwAttack;

        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(attackpos.position, attackRange);
    } 
}
