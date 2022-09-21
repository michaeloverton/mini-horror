using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Footstep events.
    public delegate void AudioTriggerParameterAction(float footstepType);
    public event AudioTriggerParameterAction _onFootstepTypeTriggerEnter;

    public void OnFootstepTypeTriggerEnter(float footstepType)
    {
        if (_onFootstepTypeTriggerEnter != null) { _onFootstepTypeTriggerEnter(footstepType); }
    }
}
