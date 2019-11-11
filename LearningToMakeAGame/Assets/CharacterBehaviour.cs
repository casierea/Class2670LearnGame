using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterContoller))]
public class CharacterBehaviour : MonoBehaviour
{

    public bool canMove = true;

    public CharacterController controller;

    private WaitForFixedUpdate wftuObj;

    public void Awake()
    {
        controller = GetComponent<CharacterController>();
        character.Controller = controller;
    }
    
}
