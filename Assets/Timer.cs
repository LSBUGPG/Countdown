using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    RectTransform rectangle;
    float time = 0.0f;

    void Start()
    {
        rectangle = GetComponent<RectTransform>();
        rectangle.localRotation = Quaternion.identity;
        StartTimer();
    }

    void Update()
    {
        rectangle.localRotation = Quaternion.Euler(0.0f, 0.0f, -time * 6.0f);
    }

    public void StartTimer()
    {
        time = 0.0f;
        StartCoroutine(TimerUpdate());
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
