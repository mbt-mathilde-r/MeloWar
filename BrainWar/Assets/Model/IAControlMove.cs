using UnityEngine;

public class IAControlMove : MonoBehaviour
{
    [SerializeField] private int maxMoveDuration = 30;
    [SerializeField] private int minMoveDuration = 10;

    private Movable movableComponent;
    private Rotable rotableComponent;

    private int moveDuration = 0;
    private int moveIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        movableComponent = gameObject.GetComponent<Movable>();
        rotableComponent = gameObject.GetComponent<Rotable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDuration == 0) {
            generateNewMove();
            rotableComponent.applyTranformation(moveIndex);
        }

        movableComponent.applyTranformation(Transformable.MethodIndex.Up);
        moveDuration--;
    }

    private void generateNewMove()
    {
        moveDuration = Random.rand(minMoveDuration, maxMoveDuration);
        moveIndex = Random.rand(0, movableComponent.all.Length);
    }
}
