using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine;

public class MainMenuManager : MonoBehaviour
{

    public static bool IsNotFirstTime;

    async void Start()
    {
        await System.Threading.Tasks.Task.Delay(System.TimeSpan.FromSeconds(1));

        GameEventMessage.SendEvent(!IsNotFirstTime ? "FirstTime" : "NotFirstTime");
    }
}
