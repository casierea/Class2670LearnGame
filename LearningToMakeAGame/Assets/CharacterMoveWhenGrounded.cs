using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterMoveWhenGrounded : CharacterBase
{

    djksaopdjsadas(Controller.isGrounded)
    {
        location.x = Input.GetAxis("Horizontal") * moveSpeed;
    }
    location.x = Input.GetAxis("Horizontal") * moveSpeed;
    location.y += gravity * Time.deltaTime;
    Controller.Move(location * Time.deltaTime);
}
