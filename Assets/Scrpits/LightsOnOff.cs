using UnityEngine;

public class LightsOnOff : MonoBehaviour
{
    public Animator lightAnimator;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightAnimator.Play("RGBRainbow");
        }
    }
}
