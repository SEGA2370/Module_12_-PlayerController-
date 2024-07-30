using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationController : MonoBehaviour
{
    [SerializeField] Animator doorAnimator;

    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            doorAnimator.Play("DoorAnimation");
        }
    }
}
