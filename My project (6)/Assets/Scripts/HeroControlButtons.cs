using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControlButtons : MonoBehaviour
{
    public Joystick joystick;

    private void Update()
    {
        if(joystick.Horizontal > 0.1f)
        {
            HeroController.moveInput = 1;
        }
        else if(joystick.Horizontal < -0.1f)
        {
            HeroController.moveInput = -1;
        }
        else
        {
            HeroController.moveInput = 0;
        }
    }
}
