using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterMovement : CharacterBase
{
    public override void Move()
    {
        Location.x = Input.GetAxis("Horizontal") *speed;
        base.Move();
    }
   
}

