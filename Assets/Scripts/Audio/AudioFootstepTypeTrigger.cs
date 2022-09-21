using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFootstepTypeTrigger : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private float footstepType;

    void OnTriggerEnter(Collider other)
    {
        audioManager.OnFootstepTypeTriggerEnter(footstepType);
    }
}
