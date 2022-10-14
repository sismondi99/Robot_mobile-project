using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineAEtatsScript : MonoBehaviour 
{
    public MaterielScript Mat; // Couche Matérielle
    public NavigationScript NavigationI3DTechnique; // Couche I3D
    public SelectionScript SelectionI3DTechnique; // Couche I3D
    public ManipulationScipt ManipulationI3DTechnique; // Couche I3D
    public Application App; // Couche Application TP2 Scène 6
    public BougeBaseMobile gestionBaseMobile; // Gestion des objets de la scène Unity
    public gere_bras gestionBrasArticule; // Gestion des objets de la scène Unity
    public PrendObjet gestionPince; // Gestion des objets de la scène Unity non physicalisé TP2 scene 4
    //public EtatCube cube;
    private GameObject cube_selectionnable;
    private GameObject cube_selectionne;
    private string compteur_temps;


    public enum EtatsVR { Selection, Manipulation, Navigation };
    public EtatsVR etatVR;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
