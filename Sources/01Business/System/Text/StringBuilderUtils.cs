﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : StringBuilderUtils.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet StringBuilderUtils
// Créé le       : 28/02/2015
// Modifié le    : 17/07/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "System.Text"
//*******************************************************************************************************************************
namespace System.Text
	{

    //   ####  #####  ####   #  #   #   ###           ####   #   #  #  #      ####   #####  #### 
    //  #        #    #   #  #  ##  #  #   #          #   #  #   #  #  #      #   #  #      #   #
    //   ###     #    ####   #  # # #  #       #####  ####   #   #  #  #      #   #  ###    #### 
    //      #    #    #   #  #  #  ##  #   ##         #   #  #   #  #  #      #   #  #      #   #
    //  ####     #    #   #  #  #   #   ### #         ####    ###   #  #####  ####   #####  #   #

	//***************************************************************************************************************************
	// Classe StringBuilderUtils
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Fournit des méthodes utilisées pour manipuler les couleurs.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public static class StringBuilderUtils
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Signale l'index de la première occurrence de la chaîne spécifiée dans cette instance.
		/// </summary>
		/// <param name="Self">Objet <b>StringBuilder</b>.</param>
		/// <param name="Value">Chaîne à rechercher.</param>
		/// <param name="Start">Position de départ de la recherche.</param>
		/// <returns>
		/// Position d'index de base zéro de value si cette chaîne est disponible ou -1 si 
		/// elle est introuvable.
		/// </returns>
		//-----------------------------------------------------------------------------------------------------------------------
		public static int IndexOf ( this StringBuilder Self, string Value, int Start )
			{
			//-------------------------------------------------------------------------------------------------------------------
			for ( int Index = Start ; Index <= Self.Length - Value.Length ; Index ++ )
				{
				//---------------------------------------------------------------------------------------------------------------
				if ( Self[Index] == Value[0] )
					{
					int Indice = Index - 1;

					foreach ( char Car in Value )
						{
						if ( Self[++Indice] != Car ) { Indice = -1; break; }
						}

					if ( Indice != -1 ) return Indice - Value.Length;
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			return -1;
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "System"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
