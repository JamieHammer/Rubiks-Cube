using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateCube : MonoBehaviour {

    public GameObject cubelet;

    [Header("Customise Rubik's Cube")]
    [SerializeField]
    private int size = 3;
    [SerializeField]
    private bool instanciate = false;

    private int rowCube;       //position of next cube
    private int columnCube;    //position of next cube

    void Start()
    {
        instanciate = true;
    }

    private void Update()
    {
       if (instanciate)
        {
            Clear();
            Instanciate();
            instanciate = false;
        }
    }

    private void Clear()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    private void Instanciate()
    {
        Front();
        Left();
        Right();
        Rear();
        Top();
        Bottom();
    }

    void Front()
    {
        rowCube = 0;
        columnCube = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Instantiate(cubelet, new Vector3(0, columnCube, rowCube), new Quaternion(0, 0, 0, 0), this.transform);
                rowCube++;
            }
            rowCube = 0;
            columnCube++;
        }
    }

    void Left()
    {
        rowCube = 1;
        columnCube = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - 1; j++)
            {
                Instantiate(cubelet, new Vector3(-rowCube, columnCube, 0), new Quaternion(0, 0, 0, 0), this.transform);
                rowCube++;
            }
            rowCube = 1;
            columnCube++;
        }
    }

    void Right()
    {
        rowCube = 1;
        columnCube = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - 1; j++)
            {
                Instantiate(cubelet, new Vector3(-rowCube, columnCube, size - 1), new Quaternion(0, 0, 0, 0), this.transform);
                rowCube++;
            }
            rowCube = 1;
            columnCube++;
        }
    }

    void Rear()
    {
        rowCube = 1;
        columnCube = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - 2; j++)
            {
                Instantiate(cubelet, new Vector3(-size + 1, columnCube, rowCube), new Quaternion(0, 0, 0, 0), this.transform);
                rowCube++;
            }
            rowCube = 1;
            columnCube++;
        }
    }

    void Top()
    {
        rowCube = 1;
        columnCube = 1;

        for (int i = 2; i < size; i++)
        {
            for (int j = 1; j < size - 1; j++)
            {
                Instantiate(cubelet, new Vector3(-columnCube, size-1, rowCube), new Quaternion(0, 0, 0, 0), this.transform);
                rowCube++;
            }
            rowCube = 1;
            columnCube++;
        }
    }

    void Bottom()
    {
        rowCube = 1;
        columnCube = 1;

        for (int i = 2; i < size; i++)
        {
            for (int j = 1; j < size - 1; j++)
            {
                Instantiate(cubelet, new Vector3(-columnCube, 0, rowCube), new Quaternion(0, 0, 0, 0), this.transform);
                rowCube++;
            }
            rowCube = 1;
            columnCube++;
        }
    }
}
