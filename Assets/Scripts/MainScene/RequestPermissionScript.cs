using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class RequestPermissionScript : MonoBehaviour
{ 

    void Start()
    {
        Permission.RequestUserPermission(Permission.Camera);
    }

    void OnApplicationFocus(bool focus)
    {
        if (Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Debug.Log("Permission Allowed");
            // Delete comment later
            // SceneManager.LoadScene("AR");
        }
        else
        {
            Debug.Log("Permission Denied");
        }
    }

}