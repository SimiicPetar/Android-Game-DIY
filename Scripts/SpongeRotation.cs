using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class SpongeRotation : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
    }

    public void RotateLeft()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, 45, 0), 0.5f);
    }
    public void Idle()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
    }
    public void RotateRight()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(0, -45, 0), 0.5f);
    }
    public void RotateUp()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(35, 0, 0), 0.5f);
    }
    public void RotateDown()
    {
        this.gameObject.transform.DOLocalRotate(new Vector3(-35, 0, 0), 0.5f);
    }
}
