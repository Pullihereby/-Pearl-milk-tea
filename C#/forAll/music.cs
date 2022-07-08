using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public void Play(AudioSource audioData)
    {
        if (audioData != null)
        {
            audioData.Play(0);
        }
    }
}
