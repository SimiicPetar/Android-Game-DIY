using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class MoveBackPackEnd : MonoBehaviour
{
    [SerializeField] private GameObject completedBackpack;
    [SerializeField] private Transform endPosition;
    [SerializeField] private Transform parent;

    [SerializeField] private GameObject girl;

    public void MoveBackPack()
    {
        completedBackpack.transform.DOLocalMove(new Vector3(-0.04237442f, 0.07056973f, -0.1978734f), 0f);
        completedBackpack.transform.DOLocalRotate(new Vector3(-85.737f, 101.998f, 95.501f), 0.1f);
        completedBackpack.transform.parent = parent.transform;
    }


}
