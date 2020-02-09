using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
    private Transform owner;
    private Rigidbody rb;
    public float speed = 5f;
    public float maxDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        owner = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(owner.position, transform.position);
        if (distance >= maxDistance)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, owner.position, step);
        }
    }
}
