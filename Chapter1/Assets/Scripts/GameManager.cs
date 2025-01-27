using UnityEngine;

/// <summary>
/// Manages the main gameplay of the game
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Variables
    [Tooltip("Reference to the tile we want to spawn")]
    public Transform tile;

    [Tooltip("Where the first tile should be placed")]
    public Vector3 startPoint = new Vector3(0, 0, -5);

    [Tooltip("How many tiles should be spawned in advance")]
    [Range(1, 15)]
    public int initSpawnCount = 10;

    /// <summary>
    /// Where the next tile should be spawned at
    /// </summary>
    private Vector3 nextTileLocation;

    /// <summary>
    /// How should the next tile be rotated
    /// </summary>
    private Quaternion nextTileRotation;
    #endregion

    /// <summary>
    /// Start is called before the first frame Update
    /// </summary>
    private void Start()
    {
        //Set the startPoint
        nextTileLocation = startPoint;
        nextTileRotation = Quaternion.identity;

        for (int i = 0; i < initSpawnCount; i++)
        {
            SpawnNextTile();
        }

    }

    /// <summary>
    /// Will spawn a tile at a certain location
    /// and set up the next position
    /// </summary>
    void SpawnNextTile()
    {
        var newTile = Instantiate(tile, nextTileLocation, nextTileRotation);

        //Figure out where and at what rotation we should spawn the next tile
        var nextTile = newTile.Find("NextSpawnPoint");
        nextTileLocation = nextTile.position;
        nextTileRotation = nextTile.rotation;
    }
}
