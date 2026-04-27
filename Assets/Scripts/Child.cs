using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{
    public GameObject parent_1;
    public GameObject parent_2;
    public GameObject baby;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {           

            print("Bebe creado");

            GameObject copy = Instantiate(baby, transform.position, Quaternion.identity);

            setColor(copy);
            setShape(copy);
        }
    }

    void setColor(GameObject copy)
    {
        if (Random.value < 0.5)
        {
            //Parent 1 for gene 1
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().color_1 = parent_1.GetComponent<Genetics>().color_1;
            }
            else
            {
                //Gene 2
                copy.GetComponent<Genetics>().color_1 = parent_1.GetComponent<Genetics>().color_2;
            }

            //Parent 2 for gene 2
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().color_2 = parent_2.GetComponent<Genetics>().color_1;
            }
            else
            {
                //Gene 2
                copy.GetComponent<Genetics>().color_2 = parent_2.GetComponent<Genetics>().color_2;
            }
        }
        else
        {
            //parent 2 for gene 1
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().color_1 = parent_2.GetComponent<Genetics>().color_1;
            }
            else
            {
                //Gene 2
                copy.GetComponent<Genetics>().color_1 = parent_2.GetComponent<Genetics>().color_2;
            }

            //Parent 1 for gene 2
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().color_2 = parent_1.GetComponent<Genetics>().color_1;
            }
            else
            {
                //Gene 2
                copy.GetComponent<Genetics>().color_2 = parent_1.GetComponent<Genetics>().color_2;
            }
        }
    }

    void setShape(GameObject copy)
    {
        //Choose parent for gene 1
        if (Random.value < 0.5)
        {
            //Parent 1 for gene 1
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().shape_1 = parent_1.GetComponent<Genetics>().shape_1;
            } else
            {
                //Gene 2
                copy.GetComponent<Genetics>().shape_1 = parent_1.GetComponent<Genetics>().shape_2;
            }

            //Parent 2 for gene 2
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().shape_2 = parent_2.GetComponent<Genetics>().shape_1;
            }
            else
            {
                //Gene 2
                copy.GetComponent<Genetics>().shape_2 = parent_2.GetComponent<Genetics>().shape_2;
            }
        } else
        {
            //parent 2 for gene 1
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().shape_1 = parent_2.GetComponent<Genetics>().shape_1;
            }
            else
            {
                //Gene 2
                copy.GetComponent<Genetics>().shape_1 = parent_2.GetComponent<Genetics>().shape_2;
            }

            //Parent 1 for gene 2
            if (Random.value < 0.5)
            {
                //Gene 1
                copy.GetComponent<Genetics>().shape_2 = parent_1.GetComponent<Genetics>().shape_1;
            }
            else
            {
                //Gene 2
                copy.GetComponent<Genetics>().shape_2 = parent_1.GetComponent<Genetics>().shape_2;
            }
        }
    }
}
