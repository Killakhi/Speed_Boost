using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedbar : MonoBehaviour
{
    public Slider speedBar;

    public void fastorNot(float speed)
    {
       speedBar.value = speed;
    }
}
