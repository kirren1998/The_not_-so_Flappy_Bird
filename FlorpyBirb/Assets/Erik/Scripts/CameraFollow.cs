﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private void Update()
    {
        transform.position = new Vector3(player.position.x + 8, transform.position.y, -10);
    }
}
