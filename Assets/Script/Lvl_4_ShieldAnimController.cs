using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl_4_ShieldAnimController : MonoBehaviour
{
    [SerializeField] Animator shieldAnimator;

    void Start()
    {
        shieldAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            shieldAnimator.Play("Lvl_4_ShieldAnimation");
        }
    }
}