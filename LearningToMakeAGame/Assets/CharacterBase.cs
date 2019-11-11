using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float gravity = 9.81f;
    public float jumpSpeed = 75f;
    public CharacterController Controller { get; set; }

    protected Vector3 location;

    protected Vector3 orientation;

    public virtual void Move();
    {
        location.x = Input.GetAxis("Horizontal") * moveSpeed;
        location.y += gravity * Time.deltaTime;
        Controller.Move(location * Time.deltaTime);
    }
   
}
