using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosable : MonoBehaviour
{
    [SerializeField] private Explosion explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void explode()
    {
        print(explosion);
        explosion.transform.position = gameObject.transform.position;
        explosion.explode();
    }
}
