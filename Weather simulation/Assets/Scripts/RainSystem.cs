using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSystem : MonoBehaviour
{
    //https://docs.unity3d.com/ScriptReference/ParticleSystem.EmissionModule-enabled.html
    //http://answers.unity3d.com/questions/1135844/unity-5-turning-particles-onoff.html
    //http://answers.unity3d.com/questions/292745/how-do-i-create-instatiate-an-array-of-gameobjects.html


    public GameObject RainZone1;
    public GameObject RainZone2;

    public ParticleSystem Rain01;
    public ParticleSystem Rain02;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(RainZone1.transform.position, RainZone2.transform.position) < 25.0f)
        {
            RainPlay();
            Debug.Log("Rain is playing");
        }
        else
        {
            RainStop();
        }
    }

    void RainPlay()
    {
        Rain01.Play();
        Rain02.Play();
    }
    void RainStop()
    {
        Rain01.Stop();
        Rain02.Stop();
    }
}
