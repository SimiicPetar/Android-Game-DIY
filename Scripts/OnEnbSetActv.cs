using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnbSetActv : MonoBehaviour
{

    public GameObject imageOutline;

    void OnEnable()
    {
        imageOutline.SetActive(true);
    }


    void OnDisable()
    {
        imageOutline.SetActive(false);
    }
}
