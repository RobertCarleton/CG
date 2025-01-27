using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// Reference to Player Rigidbody
    /// </summary>
    private Rigidbody rb;

    [Header("How fast the ball moves left / right")]
    //How fast ball moves left and right
    [Tooltip("How fast the ball moves left / right")]
    public float dodgeSpeed = 5f;

    [Header("How fast the ball moves forward automatically")] 
    //How fast ball moves forward
    [Tooltip("How fast the ball moves forward automatically")]
    [Range(0f, 10f)]
    public float rollSpeed = 5f;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// FixedUpdate is a prime place to put physics calculations
    /// happening over a period of time
    /// </summary>
    private void FixedUpdate()
    {
        //Check if we are moving to the side
        var horizonatalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;
        
        rb.AddForce(horizonatalSpeed, 0, rollSpeed);
    }
}
