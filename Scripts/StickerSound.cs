using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerSound : MonoBehaviour
{
    [SerializeField] private AudioSource stickerSound;

    private void Update()
    {
        RaycastHit hit;
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            stickerSound.Play();
        }
    }
}
