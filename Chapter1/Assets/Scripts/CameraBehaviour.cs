using UnityEngine;

/// <summary>
/// The class will adjust the camera to follow and face a target
/// </summary>
public class CameraBehaviour : MonoBehaviour
{
    #region Variables
    [Tooltip("What object the camera should be looking at")]
    public Transform target;

    [Tooltip("How offset will the camera be to the target")]
    public Vector3 offset = new Vector3(0, 3, -6);
    #endregion
    /// <summary>
    /// Update is called once per frame
    /// </summary>
    private void Update()
    {
        //Check if the target is a null object
        if (target != null)
        {
            //Set the postion to an offset of our target
            transform.position = target.position + offset;

            //Change the roation to face the target
            transform.LookAt(target.position);
        }
    }
}
