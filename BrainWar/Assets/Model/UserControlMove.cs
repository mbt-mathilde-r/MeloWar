using UnityEngine;

public class UserControlMove : MonoBehaviour
{
    [SerializeField] private KeyCode upKey = KeyCode.W;
    [SerializeField] private KeyCode downKey = KeyCode.S;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    private Movable movableComponent;
    private Rotable rotableComponent;

    // Delegate
    private KeyCode[] keys;

    // Start is called before the first frame update
    void Start()
    {
        movableComponent = gameObject.GetComponent<Movable>();
        rotableComponent = gameObject.GetComponent<Rotable>();
        keys = new KeyCode[] { upKey, downKey, leftKey, rightKey };
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if (Input.GetKey(keys[i]))
            {
                rotableComponent.applyTranformation(i);
                movableComponent.applyTranformation(Transformable.MethodIndex.Up);
            }
        }
    }

    // Handle collision
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
