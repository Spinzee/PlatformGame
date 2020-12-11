using System.Collections;
using UnityEngine;

public static class AudioSourceExtensions
{
    public static void Fade(this AudioSource audio, float duration, float targetVolume)
    {
        audio.GetComponent<MonoBehaviour>().StartCoroutine(FadeCore(audio, duration, targetVolume));
    }

    private static IEnumerator FadeCore(AudioSource audio, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audio.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audio.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }

        yield break;
    }
}
