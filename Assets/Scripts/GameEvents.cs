using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class GameEvents
{
    public static event Action onClick;

    public static void InvokeOnClick()
    {
        onClick?.Invoke();
    }
}
