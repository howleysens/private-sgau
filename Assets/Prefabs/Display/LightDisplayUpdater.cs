using System.Collections;
using UnityEngine;
using TMPro; 
public class LightDisplayUpdater : MonoBehaviour, IMicrocontollerProgram
{
    public RSMAGPIO GPIO { get; set; }
    public RSMADataTransferMaster dataBus { get; set; }

    public TextMeshPro displayText;

    public LightSensorScript lightSensor;

    public IEnumerator MainProgramm()
    {
        while (true)
        {
            if (lightSensor != null && displayText != null)
            {
                displayText.text = $"Light: {lightSensor.lightIntensity:F2}";
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
