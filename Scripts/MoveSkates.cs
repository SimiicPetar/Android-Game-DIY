using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSkates : MonoBehaviour
{
    public Animator Animations;

    public void PaintRight()
    {
        Animations.SetBool("right", true);
        Animations.SetBool("left", false);
        Animations.SetBool("idle", false);

    }

    public void PaintLeft()
    {
        Animations.SetBool("left", true);
        Animations.SetBool("right", false);
        Animations.SetBool("idle", false);

    }
     public void Idle()
    {
        Animations.SetBool("idle", true);
        Animations.SetBool("right", false);
        Animations.SetBool("left", false);

    }
}
