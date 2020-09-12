using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript01 : MonoBehaviour
{
    public float testfloat1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        testfloat1 += Time.deltaTime;
    }
}
