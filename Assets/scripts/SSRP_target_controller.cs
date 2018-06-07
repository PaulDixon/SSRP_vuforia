using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSRP_target_controller : MonoBehaviour {
    PersistantManager boss;// = PersistantManager.Instance;

    // when the Sensor is within Marker distances (within 15m)
    // we allow the the sensorManager to swap over from using icons as visual tracking to an actual marker.
    // we spawn in the market using this. Prefab with the specific Marker ID given to us from the sensor data itself.
    // we can compar this to the Marker DB and generate the expected marker to track.
    // This also provides and anchor point for adding the Sensor Information.

    public string markerid;
    public GameObject contextElementView;
    public GameObject ImageTarget;
    
    public bool isMarkerTractedAndActive = false;
    private SSRP_context_element_controller contextElement;


    /*
    private List<MVC_entity> prefabList;
    bool hasPrefabs = false;
   */
    

    // Use this for initialization
    void Start () {
        //markerid = "eed385f01b6d4f11a32a43304d6deb2f";
        boss = PersistantManager.Instance;
       if(contextElementView != null)
        {
            contextElement = contextElementView.GetComponent<SSRP_context_element_controller>();
        }
      
    }

    public void initFor(string _marker_id, SSRP_ContextElement _context_el)
    { 
        markerid = _marker_id;
        // access Vuforia;
        if (contextElement)
        { contextElement.importData(_context_el); }
       

    }
	// Update is called once per frame
	void Update () {
		
	}
}
