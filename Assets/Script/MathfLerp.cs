using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfLerp : MonoBehaviour
{
    [SerializeField] private Vector3 goalPosition;
    [SerializeField] private float speed = 0.5f;
    private float current, target;

    private void Start()
    {
        var myValue = Mathf.Lerp(0, 10, 0.5f);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) target = target == 0 ? 1 : 0;
        current = Mathf.MoveTowards(current, target, speed * Time.deltaTime);

        transform.position = Vector3.Lerp(Vector3.zero, goalPosition, current);
    }
}
