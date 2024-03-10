using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class PlayerSpotted : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Spotted()
    {
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
    }
}
