using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float chargePoint = 0;
    private float finalPoint = 0;

    private void Update()
    {
        Charge();
    }

    private void Charge()
    {
        if (Input.GetMouseButton(0))
        {
            chargePoint += Time.deltaTime * 8; // *5 to make it go faster
        }
        else if (Input.GetMouseButtonUp(0))
        {
            finalPoint = chargePoint;
        }
        else
        {
            chargePoint = 0; // reset value
            finalPoint = 0; // reset value in variable finalPoint
        }
    }

    public float GetChargePoint() // Send it to Display Class
    {
        return Mathf.Round(chargePoint);
    }

    public float GetFinalPoint() // Send it to Box Class
    {
        return Mathf.Round(finalPoint);
    }
}
