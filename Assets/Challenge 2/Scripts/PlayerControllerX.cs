using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int maxClicksPerSecond = 2; 
    private Stopwatch _stopwatch;
    private long _cooldownTicks;



    private void Start()
    {
        _stopwatch = Stopwatch.StartNew();
        _cooldownTicks = (long)(TimeSpan.TicksPerSecond / maxClicksPerSecond);
    }



    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (_stopwatch.ElapsedTicks >= _cooldownTicks))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            _stopwatch.Restart();
        }
    }
}
