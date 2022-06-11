using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GirlMove : MonoBehaviour
{
    [SerializeField] private Transform endPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(endPosition.transform.position, 2f);
    }
}
