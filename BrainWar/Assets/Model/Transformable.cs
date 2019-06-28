using UnityEngine;
using System.Collections;

public abstract class Transformable : MonoBehaviour
{
    public enum MethodIndex
    {
        Up = 0, Down, Left, Right
    }

    // Delegate for moves methods
    internal delegate void selfTransform();

    // All move methods
    internal selfTransform[] all { get; private set; }

    internal MethodIndex lastTransform;

    // Use this for initialization
    void Start()
    {
        print("Start");
        all = new selfTransform[] { up, down, left, right };
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void applyTranformation(MethodIndex method)
    {
        applyTranformation((int)method);
    }

    public void applyTranformation(int method)
    {
        lastTransform = (MethodIndex)method;
        all[method]();
    }

    abstract internal void up();
    abstract internal void down();
    abstract internal void left();
    abstract internal void right();
}
