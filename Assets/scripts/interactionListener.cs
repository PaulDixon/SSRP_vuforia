using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionListener : MonoBehaviour {
    private PersistantManager boss;
    // Use this for initialization
    void Start () {
        boss = PersistantManager.Instance;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                boss.hud.addText("MouseClick hit");
                try
                {
                    SSRP_context_element_controller child_controller = hit.transform.GetComponent<SSRP_context_element_controller>();
                    //child_controller.importData(entityData);

                    child_controller.isClosed = !child_controller.isClosed;
                    boss.hud.addText("hit child_controller found ");
                }
                catch
                {
                    boss.hud.addText("no script found on iteraction ");
                }



                if (hit.transform.name == "SSRP_context_element_view")
                {
                    boss.hud.addText("hit SSRP_context_element_view ");
                }
                else
                {
                    boss.hud.addText("hit.transform.name == " + hit.transform.name);
                }
            }
            else
            {
                boss.hud.addText("MouseClick no raycast hit");
            }
        }
    }
}

