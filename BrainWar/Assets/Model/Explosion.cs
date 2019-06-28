using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private ParticleSystem particles;
    private AudioSource audioSource;

    private bool didActivePArticle = false;

    // Start is called before the first frame update
    void Start()
    {
        particles = gameObject.GetComponent<ParticleSystem>();
        audioSource = gameObject.GetComponent<AudioSource>();
        print(particles);    
    }

    // Update is called once per frame
    void Update()
    {
        if (didActivePArticle && !particles.IsAlive())
        {
            didActivePArticle = false;
        }
    }

    public void explode()
    {
        if (didActivePArticle) { return; }
        didActivePArticle = true;
        particles.Play();
        audioSource.Play();
    }
}
