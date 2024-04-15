using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject barnMachine; // Reference to the BarnMachine GameObject

    private bool isLocked = true; // Initial state of the door

    // Method to unlock the door and make the BarnMachine appear
    public void Unlock()
    {
        Debug.Log("Unlock method called");
        isLocked = false;
        // Activate the BarnMachine GameObject when the door is unlocked
        if (barnMachine != null)
        {
            barnMachine.SetActive(true);
        }

        // Log that the door has been unlocked
        Debug.Log("Door unlocked");
    }

}
