using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EntityManager : MonoBehaviour
{
    public static Action OnClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && OnClick != null)
        {
            OnClick();
        }
    }

}
