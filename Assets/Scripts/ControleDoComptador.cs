using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComptador : MonoBehaviour
{
    [SerializeField]
    private float intervalo;

    private Aviao aviao;
    // Start is called before the first frame update
    private void Start()
    {
        this.aviao = this.GetComponent<Aviao>();
        StartCoroutine(this.Impulsionar());
    }

    private IEnumerator Impulsionar()
    {
        while (true)
        {
            yield return new WaitForSeconds(this.intervalo);
            this.aviao.DarImpulso();
        }
    }
}
