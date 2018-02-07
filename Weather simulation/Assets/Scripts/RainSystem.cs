using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSystem : MonoBehaviour
{
    /// <summary>
    /// TO DO:
    /// *Make the RainZones move randomly apart, when together rain
    /// *Edit sky boxes, add clouds when rainy
    /// *change lighting based on weather
    /// </summary>
    public GameObject[] RainZone;
    public ParticleSystem[] Rain;
    int i;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(RainZone[1].transform.position, RainZone[0].transform.position) < 50.0f)
        {
            RainPlay();
            //Debug.Log("Rain is playing");
        }
        else
        {
            RainStop();
        }
    }

    void RainPlay()
    {
        for (i = 0; i < 2; i++)
        {
            Rain[i].GetComponent<ParticleSystem>().enableEmission = true;
        }

    }
    void RainStop()
    {
        for (i = 0; i < 2; i++)
        {
            Rain[i].GetComponent<ParticleSystem>().enableEmission = false;
        }
    }

}
