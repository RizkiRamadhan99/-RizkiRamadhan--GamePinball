using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public ScoreManager scoreManager;

    private SwitchState state;
    private Renderer myRenderer;

    private void Start()
    {
        myRenderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }

    private void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            myRenderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            myRenderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle()
    {
        //tambah score saat menyalakan atau mematikan switch
        scoreManager.AddScore(1);

        if (state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            myRenderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            myRenderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}