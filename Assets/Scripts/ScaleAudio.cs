using System.Collections.Generic;
using UnityEngine;

public class ScaleAudio : MonoBehaviour
{
    public Transform player;
    private List<AudioSource> audioSources;

    public float minScale = 0.001f;
    public float maxScale = 1f;

    void Start()
    {
        audioSources = new List<AudioSource>(FindObjectsOfType<AudioSource>());
    }

    void Update()
    {
        float scale = player.localScale.x;
        float normalized = Mathf.InverseLerp(minScale, maxScale, scale);
        float pitch = Mathf.Lerp(0.3f, 1f, normalized);

        foreach (AudioSource source in audioSources)
        {
            source.pitch = pitch;
        }
    }
}