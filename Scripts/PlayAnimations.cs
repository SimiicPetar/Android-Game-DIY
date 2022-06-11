using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayAnimations : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject chatBubble;
    [SerializeField] private GameObject buttons;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            other.gameObject.transform.DORotate(new Vector3(0, 180, 0), 0.5f);
            anim.SetTrigger("wave");
            chatBubble.SetActive(true);
            buttons.SetActive(true);
        }
    }
}
