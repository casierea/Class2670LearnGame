using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowinPowerUp : MonoBehaviour
{
    public int coinValue = 10;
    public GameAction UpdateCoin;

    private void OnTriggerEnter(Collider other)
    {
        UpdateCoin.Raise(coinValue);
    }
}
