using UnityEngine;


public class HostileRocks : MonoBehaviour
{
    public int health;
    public GameObject SmokeDeath;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        // play a Hurt sound
        Instantiate(SmokeDeath, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("Rock Hurt");
    }
}
