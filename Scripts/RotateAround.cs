using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] private GameObject target;

    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
