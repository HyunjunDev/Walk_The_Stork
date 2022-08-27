using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EventManager : Singleton<EventManager>
{
    public static event Action DieEvent;
    public static event Action StartEvent;

    public static void StartEventing()
    {
        StartEvent?.Invoke();
    }

    public static void DieEventing()
    {
        DieEvent?.Invoke();
    }
}
