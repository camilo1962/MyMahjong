using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class CubeTouch : MonoBehaviour, IPointerDownHandler
    {

        
        void Start () {
	
        }
	
        // Update is called once per frame
        void Update ()
        {
            onMouseDown();
            IPointerDownHandler();
        }

        private void IPointerDownHandler()
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Transform objecthit = hit.transform;
                var x = Instantiate(this);
                x.transform.position = transform.position;
            }
        }

        void onMouseDown()
        {
            if (Input.GetMouseButton(0))
            {
                var x = Instantiate(this);
                x.transform.position = transform.position;
            }
                

        }

        void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Transform objecthit = hit.transform;
                var x = Instantiate(this);
                x.transform.position = transform.position;
            }
        }
    }
}
