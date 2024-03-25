using UnityEngine;

public class LightSwitchController : MonoBehaviour
{
    [SerializeField] private bool isLightOn;
    public Light pointLight;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        pointLight.enabled = false;
    }

    public void InteractiveSwitch()
    {
        if (isLightOn)
        {
            animator.SetBool("ActionDone", false);
            isLightOn = false;
            pointLight.enabled = false;
        }
        else
        {
            animator.SetBool("ActionDone", true);
            isLightOn = true;
            pointLight.enabled = true;
        }
    }
}
