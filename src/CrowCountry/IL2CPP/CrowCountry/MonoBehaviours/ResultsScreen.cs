namespace CrowCountry.MonoBehaviours;

public class ResultsScreen : MonoBehaviour
{

    private readonly WriteOnceVector3 _cubePosition = new();
    private readonly WriteOnceVector3 _cubeScale = new();
    private Transform cube;

    private void Start()
    {
        Setup();
    }

    private void OnEnable()
    {
        Setup();
    }


    private void OnDisable()
    {
        Plugin.UpdateCamera(SceneManager.GetActiveScene().name, 0f);
    }

    private void Setup()
    {
        cube = transform.Find(Const.Cube);
        if (_cubePosition.HasValue)
        {
            cube.position = _cubePosition.Value;
        }
        else
        {
            cube.position = cube.position with {x = 0};
            _cubePosition.Value = cube.position;
        }

        if (_cubeScale.HasValue)
        {
            _cubeScale.Value = cube.localScale;
        }
        else
        {
            var x = cube.localScale.x * Plugin.PositiveScaleFactor;
            var y = cube.localScale.y * Plugin.PositiveScaleFactor;
            var z = cube.localScale.z;
            cube.localScale = new Vector3(x, y, z);
            _cubeScale.Value = cube.localScale;
        }
        
    }
}