using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSystem : MonoBehaviour
{
    //https://docs.unity3d.com/ScriptReference/ParticleSystem.EmissionModule-enabled.html
    //http://answers.unity3d.com/questions/1135844/unity-5-turning-particles-onoff.html
    //http://answers.unity3d.com/questions/292745/how-do-i-create-instatiate-an-array-of-gameobjects.html

    public GameObject[] RainZones;
    public ParticleSystem[] RainParticles;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RainSystemFunction();
    }

    void CloudMove()
    {

    }

    void RainSystemFunction()
    {
        for (int i = 0; i < 2; i++)
        {
            ParticleSystem CurrRainZone = RainParticles[i];
            for (int k = 0; k < 2; k++)
            {
                ParticleSystem OtherRainZone = RainParticles[k];
                if (RainParticles[i] != RainParticles[k])
                {
                    if (Vector3.Distance(CurrRainZone.transform.position, OtherRainZone.transform.position) <= 25.0f)
                    {
                        CurrRainZone.Play();
                        OtherRainZone.Play();
                    }
                    else
                    {
                        CurrRainZone.Stop();
                        OtherRainZone.Stop();
                    }
                }
            }
        }
    }
}

