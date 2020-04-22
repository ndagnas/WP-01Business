﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : RestRequestResult.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet RestRequestResult
// Créé le       : 24/03/2015
// Modifié le    : 28/06/2015
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
	
    //  ####   #####   ####  #####         ####   #####   ####  #   #  #      #####
    //  #   #  #      #        #           #   #  #      #      #   #  #        #  
    //  ####   ###     ###     #    #####  ####   ###     ###   #   #  #        #  
    //  #   #  #          #    #           #   #  #          #  #   #  #        #  
    //  #   #  #####  ####     #           #   #  #####  ####    ###   #####    #  

	//***************************************************************************************************************************
	// Enumérateur RestRequestResult
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Définit les erreurs possibles suite à un appel au Web-Service.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public enum RestRequestResult
		{
		/// <summary>
		/// Le service n'a pas répondu.
		/// </summary>
		EmptyResponse     ,
		/// <summary>
		/// Le service interdit l'app.
		/// </summary>
		Forbidden         ,
		/// <summary>
		/// Une exception non prévue c'est produite.
		/// </summary>
		InternalException ,
		/// <summary>
		/// Le format de la réponse est incorrect.
		/// </summary>
		InvalideFormat,
		/// <summary>
		/// La page n'a pas été trouvée.
		/// </summary>
		NotFound          ,
		/// <summary>
		/// Le contenue est partiel.
		/// </summary>
		PartialContent    ,
		/// <summary>
		/// Un proxy demande une identification.
		/// </summary>
		ProxyAccessRequest,
		/// <summary>
		/// Le service n'est pas disponible.
		/// </summary>
		ServiceUnavailable,
		/// <summary>
		/// Aucune erreur.
		/// </summary>
		Success           ,
		/// <summary>
		/// Le service n'a pas répondu.
		/// </summary>
		Timeout           ,
		/// <summary>
		/// Le service refuse l'app.
		/// </summary>
		Unauthorized      ,
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************
	
	} // Fin du namespace "NextRadio.Service"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
