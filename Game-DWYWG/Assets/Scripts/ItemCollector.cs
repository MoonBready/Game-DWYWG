using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class ItemCollector : MonoBehaviour
{
    int points = 0;

    [SerializeField] Text pointsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            Destroy(other.gameObject);
            points++;
            pointsText.text = "Points: " + points;
        }
    }
}
