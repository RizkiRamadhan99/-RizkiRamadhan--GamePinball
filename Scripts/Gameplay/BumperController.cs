using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public AudioManager audioManager;
    public VFXManager VFXManager;
    public ScoreManager scoreManager;
    public Collider bola;
    public float multiplier;
    public Color color;

    private Renderer myRenderer;
    private Animator animator;

    private void Start()
    {
        myRenderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        myRenderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            audioManager.PlaySFX(collision.transform.position);
            VFXManager.PlayVFX(collision.transform.position);
            //tambah score saat menabrak bumper
            scoreManager.AddScore(1);

            animator.SetTrigger("hit");
        }
    }
}
