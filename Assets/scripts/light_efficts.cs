using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_efficts : MonoBehaviour
{
    private Light our_light;
    [SerializeField] bool nigative;
    
    void Start()
    {
        our_light = GetComponent<Light>();
    }

    void Update()
    {
        if (nigative == false)
            our_light.transform.Rotate(0, 100 * Time.deltaTime, 0, Space.Self);
        else
            our_light.transform.Rotate(0, -100 * Time.deltaTime, 0, Space.Self);
    }
}
