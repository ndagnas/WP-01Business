﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : UploadFile.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet permettant de récupérer le contenue distant
// Créé le       : 15/01/2015
// Modifié le    : 21/01/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "System.Web"
//*******************************************************************************************************************************
namespace System.Web
	{

    //  #   #  ####   #       ###    ###   ####          #####  #  #      #####
    //  #   #  #   #  #      #   #  #   #  #   #         #      #  #      #    
    //  #   #  ####   #      #   #  #####  #   #  #####  ###    #  #      ###  
    //  #   #  #      #      #   #  #   #  #   #         #      #  #      #    
    //   ###   #      #####   ###   #   #  ####          #      #  #####  #####

	//***************************************************************************************************************************
	// Classe RestWebRequest
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Définit un fichier à envoyer à un site distant.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	class UploadFile
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Initialise une nouvelle instance de l'objet <b>UploadFile</b>.
		/// </summary>
		/// <param name="Form">Nom du formulaire associé.</param>
		/// <param name="FileName">Nom du fichier.</param>
		/// <param name="Raw">Contenue du fichier à envoyer.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		public UploadFile ( string Form, string FileName, byte[] Raw )
			{
			//-------------------------------------------------------------------------------------------------------------------
			this.Form     = Form;
			this.FileName = FileName;
			this.Raw      = Raw;
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		
		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens ou définit le nom du formulaire associé.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public string Form { get; set; }
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens ou définit le nom du fichier.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public string FileName { get; set; }
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens ou définit le contenue du fichier à envoyer.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public byte[] Raw { get; set; }
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "System.Web"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
