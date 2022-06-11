using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDontDestroyOnLoad : MonoBehaviour
{
    public void DestroyDontDestroyOnLoadObject()
    {
        Destroy(GameObject.Find("SoundManager"));
    }
}
