using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SprayCan : MonoBehaviour
{
    [SerializeField] private ParticleSystem sprayParticles;
    [SerializeField] private Transform sprayparticlesPos;
    [SerializeField] private AudioSource paintVFX;
    [SerializeField] private LayerMask layerMask;

    void Update()
    {
        RaycastHit hit;
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, layerMask))
        {
            transform.position = hit.point + new Vector3(0, 0.5f, 0);
            SpawnParticles();
        }
    }

    private void SpawnParticles()
    {

        if (Input.GetMouseButtonDown(0))
        {
            paintVFX.Play();
            sprayParticles.Play();
        }


        if (Input.GetMouseButtonUp(0))
        {
            paintVFX.Pause();
            sprayParticles.Stop();
        }

    }
}
