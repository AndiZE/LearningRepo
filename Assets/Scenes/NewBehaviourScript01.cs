using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript01 : MonoBehaviour
{
    public float testfloat1;
    public bool testbool1;
    // Start is called before the first frame update
    void Start()
    {
        testbool1 = false;

    }

    // Update is called once per frame
    void Update()
    {
        testfloat1 += Time.deltaTime;
        testbool1 = true;
    }
    public void Func1()
    {

    }
    private void Func2()
    {
        float f = 0f;
        int i = 1+1;
    }
}
