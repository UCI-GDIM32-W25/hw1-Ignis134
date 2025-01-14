using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        // sets the intial number of seeds the player has
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        // updates the UI to reflect seed counts 
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // Get inputs for horizontal and vertical movement and then moves the player
        float moveX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        _playerTransform.Translate(moveX, moveY, 0);

        // checks for a spacebar input and if there is plants a seed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        // Check if there are still seeds left to plant
        if (_numSeedsLeft > 0) 
        {

            // Instantiates a prefab at the player's location
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

            //update the seed counters 
            _numSeedsLeft--;
            _numSeedsPlanted++;

            // update the UI to reflect the new seed counts
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            
        }

        else

        {
            Debug.Log("No more seeds");
        }
    }
}
