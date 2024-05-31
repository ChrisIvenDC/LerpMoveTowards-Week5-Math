using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfMoveTowards : MonoBehaviour
{
    public Vector3 targetPosition;

    public float speed = 5.0f;


    void Start()
    {
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
