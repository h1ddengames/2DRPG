using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MasterButtonNode : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Animator nodesAnimator;

    private float width;
    private float height;

    private void Start() {
        width = this.gameObject.GetComponent<RectTransform>().rect.width;
        height = gameObject.GetComponent<RectTransform>().rect.height;
        if(nodesAnimator == null) {
            nodesAnimator = GameObject.Find("Master Node - UI").GetComponent<Animator>();
        }
    }

    public void OnPointerEnter(PointerEventData eventData) { }

    public void OnPointerExit(PointerEventData eventData) {
        if(!(eventData.position.x > 0 && eventData.position.x < width) 
            || !(eventData.position.y > 0 && eventData.position.y < height)) { 
            // If the mouse with outside the width and height of this gameobject, then turn off the nodes.
            nodesAnimator.SetBool("isVisible", false);
        } 
    }

    public void ToggleAnimation() {
        if(nodesAnimator.GetBool("isVisible")) {
            nodesAnimator.SetBool("isVisible", false);
        } else {
            nodesAnimator.SetBool("isVisible", true);
        }
    }
}