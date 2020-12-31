using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    [SerializeField] AudioSource audio;

    private Slider volumeSlider;

    void Start()
    {
        volumeSlider = GetComponent<Slider>();

        volumeSlider.value = audio.volume;        
    }


    public void OnChange()
    {
        audio.volume = volumeSlider.value;        
    }
}
