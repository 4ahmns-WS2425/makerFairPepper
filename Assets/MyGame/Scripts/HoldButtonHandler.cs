using UnityEngine;
using UnityEngine.EventSystems;

public class HoldButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPressed = false;
    private MixObjectColor objColor;
    private ColorRGB myColor;
    private Animator animator;
    [SerializeField] private GameObject animatedObjectRed, animatedObjectGreen, animatedObjectBlue;

    private void Start()
    {
        animator = animatedObjectRed.GetComponent<Animator>();
        animator.Play("pulseWindradRed");

        objColor = GameObject.FindObjectOfType<MixObjectColor>();
        if (gameObject.name.Contains("Rot"))
        {
            myColor = ColorRGB.Red;
        }
        else if (gameObject.name.Contains("Blau"))
        {
            myColor = ColorRGB.Blue;
        }
        else if (gameObject.name.Contains("Gruen"))
        {
            myColor = ColorRGB.Green;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        animator.gameObject.SetActive(false);

        isPressed = true;
        switch (myColor)
        {
            case ColorRGB.Red:
                objColor.StartParticles(ColorRGB.Red);
                break;
            case ColorRGB.Blue:
                objColor.StartParticles(ColorRGB.Blue);
                break;
            case ColorRGB.Green:
                objColor.StartParticles(ColorRGB.Green);
                break;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        objColor.StopParticles();
    }

    void Update()
    {
        if (isPressed)
        {
            objColor.DecreaseFillState(myColor);
        }   
    }

    //Später nach pulsieren erst das zweite drückbar
}
