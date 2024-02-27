using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float timeEnd = 3f;
    float timer;
    public HealthSystem other;

    int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timeEnd <= timer)
        {
            Destroy(gameObject);
            timer = 0;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        other.GetComponent<HealthSystem>().TakeDamage(damage);
        Destroy(gameObject);
    }

    
}
