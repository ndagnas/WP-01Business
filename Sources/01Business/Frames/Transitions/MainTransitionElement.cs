﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : MainTransitionElement.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet MainTransitionElement
// Créé le       : 08/05/2015
// Modifié le    : 08/05/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
using Microsoft.Phone.Controls;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextRadio.Frame"
//*******************************************************************************************************************************
namespace NextRadio.Frame
	{

    //  #####  ####    ###   #   #   ####  #  #####  #   ###   #   #   ####
    //    #    #   #  #   #  ##  #  #      #    #    #  #   #  ##  #  #    
    //    #    ####   #####  # # #   ###   #    #    #  #   #  # # #   ### 
    //    #    #   #  #   #  #  ##      #  #    #    #  #   #  #  ##      #
    //    #    #   #  #   #  #   #  ####   #    #    #   ###   #   #  #### 

	//***************************************************************************************************************************
	// MainTransitionElement
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	public class MainTransitionElement : TransitionElement
		{
		//-----------------------------------------------------------------------------------------------------------------------
		// Section des Attributs
		//-----------------------------------------------------------------------------------------------------------------------
        public static readonly DependencyProperty KeyProperty;
		//-----------------------------------------------------------------------------------------------------------------------
		
		//***********************************************************************************************************************
		#region // Section des Constructeurs
		//-----------------------------------------------------------------------------------------------------------------------
		
		//***********************************************************************************************************************
		/// <summary>
		/// Constructeur statique de l'objet <b>MainTransitionElement</b>.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		static MainTransitionElement ()
			{
			//-------------------------------------------------------------------------------------------------------------------
			KeyProperty = DependencyProperty.Register ( "Key", typeof(string), typeof(MainTransitionElement), null );
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//-----------------------------------------------------------------------------------------------------------------------
		#endregion
		//***********************************************************************************************************************
		
		//***********************************************************************************************************************
		#region // Section des Procédures Dérivées
		//-----------------------------------------------------------------------------------------------------------------------
		
		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens l'animation associée.
		/// </summary>
		/// <param name="Element">Elément à animer.</param>
		/// <returns>Animation.</returns>
		//-----------------------------------------------------------------------------------------------------------------------
		public override ITransition GetTransition ( UIElement Element )
			{
			//-------------------------------------------------------------------------------------------------------------------
			if ( Element == null ) return null;

			string Key = string.Empty;
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			var RootVisual = Application.Current.RootVisual as PhoneApplicationFrame;

			switch ( ( RootVisual == null ) ? PageOrientation.None : RootVisual.Orientation )
				{
				//---------------------------------------------------------------------------------------------------------------
				case PageOrientation.Landscape      :
				case PageOrientation.LandscapeLeft  :
				case PageOrientation.LandscapeRight :
					{
					//-----------------------------------------------------------------------------------------------------------
					Element.Projection = new PlaneProjection { CenterOfRotationY = 0.98 };

					Key = this.Key + "Portrait"; break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				default :
					{
					//-----------------------------------------------------------------------------------------------------------
					Element.Projection = new PlaneProjection { CenterOfRotationX = 0.02 };

					Key = this.Key + "Landscape"; break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
            if ( ! Application.Current.Resources.Contains ( Key ) ) return null;
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			Storyboard Storyboard = (Storyboard)Application.Current.Resources[Key];

			if ( Storyboard == null ) return null;
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
            Storyboard.SetTarget ( Storyboard, Element );

            return new Transition ( Element, Storyboard );
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		
		//-----------------------------------------------------------------------------------------------------------------------
		#endregion
		//***********************************************************************************************************************
		
		//***********************************************************************************************************************
        /// <summary>
        /// Obtiens ou définit la clé d'animation.
        /// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public string Key
			{
			//-------------------------------------------------------------------------------------------------------------------
			get { return (string)base.GetValue ( KeyProperty        ); }
			set {                base.SetValue ( KeyProperty, value ); }
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextRadio.Frame"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
