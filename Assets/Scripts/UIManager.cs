using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.onClick += ShowDebug;
    }
    private void OnDisable()
    {
        GameEvents.onClick -= ShowDebug;
    }

    void ShowDebug()
    {
        Debug.Log("Click");
    }
}
