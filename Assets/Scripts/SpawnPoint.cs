using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public ParticleSystem SpwanEffect;

    private void OnTriggerEnter(Collider other)
    {
        SpwanEffect.Play(true);
    }

}
