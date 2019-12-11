using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    private AudioSource footstep_Sound;

    [SerializeField]
    private AudioClip[] footstep_Clip;

    private CharacterController character_Controller;

    [HideInInspector]
    public float volume_Min = 0.5f, volume_Max = 0.1f;
    private float accumulated_Distance;

    [HideInInspector]
    public float step_Distance = 7.5f;

    void Awake()
    {
        footstep_Sound = GetComponent<AudioSource>();
        character_Controller = GetComponentInParent<CharacterController>();
    }

    void Update()
    {
        CheckToPlayFootstepSound();
    }

    void CheckToPlayFootstepSound()
    {

        
        if (!character_Controller.isGrounded)
            return;
        
        if (character_Controller.velocity.sqrMagnitude > 0)
        {
            accumulated_Distance += Time.deltaTime;
    
            if (accumulated_Distance > step_Distance)
            {

                footstep_Sound.volume = Random.Range(1f,1f);
                footstep_Sound.clip = footstep_Clip[Random.Range(0, footstep_Clip.Length)];
                footstep_Sound.Play();
                accumulated_Distance = 0f;
            }

        }
        else
        {
            accumulated_Distance = 0f;
        }
    }
} 


































