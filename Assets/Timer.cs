using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    AudioSource music;
    RectTransform rectangle;
    float time = 0.0f;

    void Start()
    {
        rectangle = GetComponent<RectTransform>();
        music = GetComponent<AudioSource>();
        rectangle.localRotation = Quaternion.identity;
    }

    void Update()
    {
        rectangle.localRotation = Quaternion.Euler(0.0f, 0.0f, 90 - time * 6.0f);
    }

    public void StartTimer()
    {
        if (time == 0.0f)
        {
            music.Play();
            StartCoroutine(TimerUpdate());
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator TimerUpdate()
    {
        while (time < 30.0f)
        {
            time = Mathf.Min(time + Time.deltaTime, 30.0f);
            yield return null;
        }
    }
}
