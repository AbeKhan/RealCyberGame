using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float timeEnd = 3f;
    float timer;
    public HealthSystem other;
    AttributesManager attribute;

    int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        attribute = GetComponent<AttributesManager>();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            attribute.DealDamage(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }



    
}
