using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BackpackRotation : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, 0, 0), 1.5f);
    }

    public void RotateLeft()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, 0, 30), 1.5f);
    }
    public void Idle()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, 0, 0), 1.5f);
    }
    public void RotateRight()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, 0, -30), 1.5f);
    }

    public void RotateUp()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(30, 0, 0), 1.5f);
    }
    public void RotateDown()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(-30, 0, 0), 1.5f);
    }
}
