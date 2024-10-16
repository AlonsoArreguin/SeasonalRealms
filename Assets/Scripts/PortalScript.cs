using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    // Name of the scene this portal leads to
    public string sceneToLoad;

    // When the player (headset) enters the portal's trigger
    private void OnTriggerEnter(Collider other)
    {
        // Replace "CenterEyeAnchor" with the actual name of the head object in your Camera Rig
        if (other.gameObject.name == "CenterEyeAnchor") 
        {
            // Load the scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
