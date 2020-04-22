﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : TextLevel.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet TextLevel
// Créé le       : 24/03/2015
// Modifié le    : 24/03/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextRadio.Service"
//*******************************************************************************************************************************
namespace NextRadio.Service
	{

    //   ####  #####   ###   #####  #   ###   #   #         #####  #   #  ####   #####
    //  #      #      #   #    #    #  #   #  ##  #           #     # #   #   #  #    
    //   ###   ###    #        #    #  #   #  # # #  #####    #      #    ####   ###  
    //      #  #      #   #    #    #  #   #  #  ##           #      #    #      #    
    //  ####   #####   ###     #    #   ###   #   #           #      #    #      #####

	//***************************************************************************************************************************
	// Enumérateur TextLevel
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Liste les types de cathégories possibles.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public enum TextLevel
		{
		/// <summary>
		/// Taille du texte plus petit.
		/// </summary>
		Small  = 0,
		/// <summary>
		/// Taille du texte moyen.
		/// </summary>
		Medium = 1,
		/// <summary>
		/// Taille du texte plus grand.
		/// </summary>
		Large  = 2,
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextRadio.Service"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
