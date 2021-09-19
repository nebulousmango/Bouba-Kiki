using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScriptSwitch : MonoBehaviour
{
    private TouchShape touchShape;

    void Start()
    {
        touchShape = GetComponent<TouchShape>();
        SwitchOffScript();
    }

    public void SwitchOffScript()
    {
        touchShape.enabled = false;
    }
    public void SwitchOnScript()
    {
        touchShape.enabled = true;
    }
}
