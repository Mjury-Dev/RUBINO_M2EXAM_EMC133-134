using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Game_Manager : MonoBehaviour
{
    public GameObject[] cars; // Array of Kart prefabs (Kart1, Kart2, Kart3)

    void Start()
    {
        int index = PlayerPrefs.GetInt("carIndex", 0); // Default to 0 if not set

        // Spawn the selected kart at the Game_Manager's position
        GameObject car = Instantiate(cars[index], transform.position, transform.rotation);

        // Find the child named "Kart" inside the spawned car
        Transform kartChild = car.transform.Find("Kart");

        if (kartChild == null)
        {
            Debug.LogError("Child object 'Kart' not found inside " + car.name);
            return;
        }

        // Find the Cinemachine Virtual Camera named "CM vcam1" in the scene
        CinemachineVirtualCamera cinemachineCam = GameObject.Find("CM vcam1")?.GetComponent<CinemachineVirtualCamera>();

        // Assign Cinemachine to follow the "Kart" child object
        if (cinemachineCam != null)
        {
            cinemachineCam.Follow = kartChild;
            cinemachineCam.LookAt = kartChild;
        }
        else
        {
            Debug.LogError("Cinemachine Virtual Camera (CM vcam1) not found!");
        }
    }
}
