
using UnityEngine;
[CreateAssetMenu]
public class CharacterMoveAndJumpGrounded : CharacterMoveWhenGrounded
{
    public override void Move()
    {
        Jump();
        base.Move();

    }

    //if(Input.GetButton("Jump"))
        //{
         //   location.y = jumpSpeed;
        //}
        //location.x = Input.GetAxis("Horizontal") * moveSpeed;
       // location.y += gravity * Time.deltaTime;
      //  Controller.Move(location * Time.deltaTime;
}
