using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PaintPrefab : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform backPack;
    [SerializeField] public LayerMask layerMask;
    void Update()
    {
        RaycastHit hit;
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, layerMask) && Input.GetMouseButtonDown(0))
        {

            Vector3 relativePos = hit.normal - transform.position;

            var badge = Instantiate(prefab, hit.point + new Vector3(0, 0.01f, 0), Quaternion.LookRotation(relativePos, hit.normal));
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation;
            badge.transform.parent = backPack.transform;
        }
    }

}
