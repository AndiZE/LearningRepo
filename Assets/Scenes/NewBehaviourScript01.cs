using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript01 : MonoBehaviour
{
    public bool testbool1;
    // Start is called before the first frame update
    void Start()
    {
        testbool1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        testbool1 = true;
    }
}
