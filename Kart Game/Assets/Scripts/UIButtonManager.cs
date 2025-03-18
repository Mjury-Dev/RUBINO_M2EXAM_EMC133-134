using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonManager : MonoBehaviour
{
    public void StartRace()
    {
        SceneManager.LoadScene("RaceScene"); // Change to your actual race scene name
    }

    public void RestartRace()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads the current scene
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu"); // Load the Menu scene
    }

    public void GoToSelection()
    {
        SceneManager.LoadScene("Selection"); // Load the Selection scene
    }

    public void GoToControls()
    {
        SceneManager.LoadScene("Controls"); // Load the Controls scene
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit(); // Quits the game (won't work in the Unity editor)
    }
}
