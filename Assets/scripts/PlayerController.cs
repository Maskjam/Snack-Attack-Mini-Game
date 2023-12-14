using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float horizontalInput;
     public float speed = 15.0f;
     public float verticalInput;
     public int score = 0;
     public AudioClip goodFood;
     public AudioClip badFood;
     private AudioSource playerAudio;
     public ParticleSystem explosionParticle;
      public ParticleSystem dirtParticle;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate( Vector3.right * horizontalInput * Time.deltaTime * speed);

          verticalInput = Input.GetAxis("Vertical");
        transform.Translate( Vector3.forward * verticalInput * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.CompareTag("goodFood"))
      {
        playerAudio.PlayOneShot(goodFood, 1.0f);
        dirtParticle.Play();
      }
      else if (other.gameObject.CompareTag("badFood"))
      {
        playerAudio.PlayOneShot(badFood, 1.0f);
        explosionParticle.Play();
      }
      
      
    }
}
