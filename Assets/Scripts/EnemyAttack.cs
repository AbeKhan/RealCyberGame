using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    AttributesManager attribute;
    // Start is called before the first frame update
    void Start()
    {
        attribute = GetComponent<AttributesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            attribute.DealDamage(collision.gameObject);
        }
    }
}
