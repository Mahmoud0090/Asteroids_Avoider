using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerhealth = other.GetComponent<PlayerHealth>();

        if(playerhealth == null) { return; }

        playerhealth.Crash();
    }

}
