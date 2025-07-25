using System;
using UnityEngine;
using System.Collections;

public class Utils
{
    // Função utilitária que inicia uma Coroutine para esperar e executar uma ação
    public static IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
