using UnityEngine;

public class LightsOnOff : MonoBehaviour
{
    public Animator lightAnimator;

    public void OnTriggerEnter(Collider other)
    {
        lightAnimator.SetBool("RGBRainbow", true);
    }
}
