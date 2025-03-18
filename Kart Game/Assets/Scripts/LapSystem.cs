using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LapSystem : MonoBehaviour
{
    public int totalLaps = 3;
    private int currentLap = 0;
    public TextMeshProUGUI lapText;

    private void Start()
    {
        if (lapText == null)
        {
            Debug.LogError("LapText UI not assigned! Drag LapText into the LapSystem script in the Inspector.");
        }
        else
        {
            UpdateLapUI();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.gameObject.name); // Debug to check detection

        if (other.CompareTag("Player"))
        {
            currentLap++;
            UpdateLapUI();
            Debug.Log("Lap: " + currentLap);

            if (currentLap >= totalLaps)
            {
                Debug.Log("Race Finished!");
                SceneManager.LoadScene("VictoryScene");
            }
        }
    }

    private void UpdateLapUI()
    {
        if (lapText != null)
        {
            lapText.text = "Lap: " + currentLap + "/" + totalLaps;
        }
    }
}
