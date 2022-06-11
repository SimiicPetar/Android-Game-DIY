using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PaintIn3D;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{
    //State machine enums
    public enum Stage
    {
        WaitingToStart,
        Cleaning,
        Painting,
        PlacingStickers,
        PlacingBadges,
        PlacingEars,
        Finish
    }

    //private references
    private Stage _stage;

    //serialized references
    [SerializeField] private Image _percentageCalc;
    [SerializeField] private GameObject _continueButton;
    [SerializeField] private GameObject _nextButton;
    [SerializeField] private GameObject _nextButton2;
    [SerializeField] private GameObject _nextButton3;
    [SerializeField] private GameObject _nextButton4;
    [SerializeField] private GameObject _nextButton5;


    [SerializeField] private GameObject starParticle;
    [SerializeField] private GameObject starParticlePos;

    [SerializeField] private GameObject sponge;
    [SerializeField] private AudioSource spongeSFX;

    [SerializeField] private GameObject tableCollider;

    [SerializeField] private AudioSource successSFX;

    [SerializeField] private float fillAmount;

    [Header("Text Fields")]
    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject text2;
    [SerializeField] private GameObject text3;


    //booleans
    private bool isDoneCleaning;

    private void Start()
    {
        StartNextStage();
    }


    private void Update()
    {
        if (!isDoneCleaning && _percentageCalc.fillAmount > fillAmount)
        {
            _continueButton.SetActive(true);
            spongeSFX.Stop();
            isDoneCleaning = true;
            sponge.SetActive(false);
        }
    }


    public void StartNextStage()
    {
        switch (_stage)
        {
            default:
            case Stage.WaitingToStart:
                _stage = Stage.Cleaning;
                break;
            case Stage.Cleaning:
                _stage = Stage.Painting;
                InstantiateStarParticles();
                text1.SetActive(true);
                Destroy(text1, 1.5f);
                StartCoroutine(DelayNextButton1());
                break;
            case Stage.Painting:
                _stage = Stage.PlacingStickers;
                InstantiateStarParticles();
                text2.SetActive(true);
                Destroy(text2, 1.5f);
                StartCoroutine(DelayNextButton2());
                break;
            case Stage.PlacingStickers:
                _stage = Stage.PlacingBadges;
                tableCollider.GetComponent<BoxCollider>().enabled = false;
                InstantiateStarParticles();
                text3.SetActive(true);
                Destroy(text3, 1.5f);
                StartCoroutine(DelayNextButton3());
                break;
            case Stage.PlacingBadges:
                _stage = Stage.PlacingEars;
                InstantiateStarParticles();
                StartCoroutine(DelayNextButton4());
                break;
            case Stage.PlacingEars:
                _stage = Stage.Finish;

                StartCoroutine(DelayNextButton5());
                break;
        }

        Debug.Log("Starting next stage: " + _stage);
    }

    public IEnumerator DelayNextButton1()
    {
        yield return new WaitForSeconds(7f);
        _nextButton.SetActive(true);
    }

    public IEnumerator DelayNextButton2()
    {
        yield return new WaitForSeconds(7f);
        _nextButton2.SetActive(true);
    }
    public IEnumerator DelayNextButton3()
    {
        yield return new WaitForSeconds(7f);
        _nextButton3.SetActive(true);
    }
    public IEnumerator DelayNextButton4()
    {
        yield return new WaitForSeconds(7f);
        _nextButton4.SetActive(true);
    }

    public IEnumerator DelayNextButton5()
    {
        yield return new WaitForSeconds(2f);
        _nextButton5.SetActive(true);
    }

    public void InstantiateStarParticles()
    {
        successSFX.Play();

        var starVFX = Instantiate(starParticle, starParticlePos.transform.position, Quaternion.identity);
        Destroy(starVFX, 2f);
    }
}
