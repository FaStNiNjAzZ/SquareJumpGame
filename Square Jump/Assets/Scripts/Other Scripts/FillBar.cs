using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{

    // Unity UI References
    public Slider slider;
    public Text displayText;
    ProgressControl progressControl;
    public float currentValue;
    
    // Create a property to handle the slider's value
    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            currentValue = value;
            slider.value = currentValue;
            displayText.text = (slider.value * 100).ToString("0.00") + "%";
        }
    }
    void Update()
    {
        currentValue = progressControl.newValue;
    }
}

