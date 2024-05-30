using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Method to load the maze scene
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }
}