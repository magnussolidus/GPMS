using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Highlight : MonoBehaviour
{
    public Color highlightColor;
    
    private MeshRenderer _myRender;
    private Color _defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        _defaultColor = this.gameObject.GetComponent<MeshRenderer>().material.color;

        if(_myRender== null)
        {
            _myRender = this._myRender = this.gameObject.GetComponent<MeshRenderer>();
        }
        
    }

    private void OnMouseEnter()
    {
        _myRender.material.color = highlightColor;
        Debug.Log("Entrou");
    }

    private void OnMouseExit()
    {
        Debug.Log("Saiu");
        _myRender.material.color = _defaultColor;
    }

}
