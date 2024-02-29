using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    Animator animator;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Xcord", transform.position.x);
        animator.SetFloat("Ycord", transform.position.y);
    }
}
//https://www.youtube.com/watch?v=dy8hkDmygRI&list=PLLtCXwcEVtulmgxqM_cA8hjIWkSNMWuie&index=12