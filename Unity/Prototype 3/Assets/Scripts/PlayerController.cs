using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public int jumpForce = 15;
    public int gravityMod = 2;
    public bool isOnGround = true;
    public bool GameOver = false;
    public Animator playerAnimator;
    public ParticleSystem smoke;
    public ParticleSystem dirt;
    public AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip dieSound;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true && !GameOver)
        {
            playerAnimator.SetTrigger("Jump_trig");
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            dirt.Stop();
            playerAudio.PlayOneShot(jumpSound);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirt.Play();
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver = true;
            Debug.Log("Game Over!");
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            smoke.Stop();
            playerAudio.PlayOneShot(dieSound);
        }
    }

}
