using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Sponge : MonoBehaviour
{
    [SerializeField] private GameObject spongeParticles;
    [SerializeField] private AudioSource cleaningSFX;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject controlsGraphics;


    void Update()
    {
        RaycastHit hit;
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, layerMask))
        {
            transform.position = hit.point + new Vector3(0, 0.1f, 0);
            SpawnParticles();

        }
    }

    private void SpawnParticles()
    {
        if (Input.GetMouseButton(0))
        {
            var spawnSpongeParticles = Instantiate(spongeParticles, transform.position, Quaternion.identity);
            Destroy(spawnSpongeParticles, 0.4f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            controlsGraphics.SetActive(false);
            cleaningSFX.Play();

        }


        if (Input.GetMouseButtonUp(0))
        {
            cleaningSFX.Pause();

        }

    }
}
