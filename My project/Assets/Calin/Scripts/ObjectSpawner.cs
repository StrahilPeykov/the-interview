using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public void SpawnObject(GameObject prefab)
    {
        switch (prefab.tag)
        {
            case ("Probe"):
                if (FormulaManager.getProbeCount() == 0)
                {
                    GameObject aux = Instantiate(prefab, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), Quaternion.identity);

                    Debug.Log("intra");
                    FormulaManager.assignProbe(aux.GetComponent<Probe>());
                }
                Debug.Log("probe cnt == " + FormulaManager.getProbeCount());
                break;
            case ("Input"):
            if (FormulaManager.inputList.Count < 26) {
                    GameObject gameObject = Instantiate(prefab, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), Quaternion.identity);
                    Debug.Log("intra");
                    FormulaManager.assignInput(gameObject.GetComponent<Switch>());
                }
                Debug.Log("num of inputs " + FormulaManager.inputList.Count);

                break;
            default:

                Instantiate(prefab, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), Quaternion.identity);
                break;
        }


    }
}
