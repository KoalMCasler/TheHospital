using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LightFlicker : MonoBehaviour
{
    public GameObject lightObject;
    public int minTimeOff;
    private int lightTimeOff;
    public int maxTimeOff;
    public GameObject lightFixtureOff;
    public GameObject LightFixtureOn;
    void Update()
    {
        StartCoroutine(flickerLights());
    }
    private IEnumerator flickerLights()
    {
        lightTimeOff = Random.Range(minTimeOff,maxTimeOff);
        lightObject.SetActive(false);
        lightFixtureOff.SetActive(true);
        LightFixtureOn.SetActive(false);
        yield return new WaitForSeconds(lightTimeOff);
        lightFixtureOff.SetActive(false);
        LightFixtureOn.SetActive(true);
        lightObject.SetActive(true);
    }
}
